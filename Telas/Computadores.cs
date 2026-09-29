using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoBan.Helpers;
using TrabalhoBan.Telas.Auxiliares;
using static TrabalhoBan.Telas.Auxiliares.frmComprarComputador;

namespace TrabalhoBan.Telas
{
    public partial class Computadores : UserControl
    {
        public Computadores()
        {
            InitializeComponent();
        }

        public async Task PopularComputadores()
        {
            string sql = @"SELECT * FROM computador";

            string pesquisa = textBox1.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(pesquisa))
                sql += $@" WHERE processador ILIKE '%{pesquisa}%' OR placa_de_video ILIKE '%{pesquisa}%' OR CAST(codigo AS TEXT) = '{pesquisa}'";

            sql += " ORDER BY codigo";

            ViewComputadores.DataSource = await Database.LerAsync(sql);
            await PopularResumo();
        }

        public async Task PopularResumo()
        {
            string sql = @"SELECT COUNT(*) FILTER (WHERE status = 0) AS livres,
                                  COUNT(*) FILTER (WHERE status = 1) AS ocupados,
                                  COUNT(*) FILTER (WHERE status = 2) AS indisponiveis
                           FROM computador";

            DataTable tabela = await Database.LerAsync(sql);
            DataRow row = tabela.Rows[0];

            lblResumo.Text = $"Livres: {row["livres"]}   |   Ocupados: {row["ocupados"]}   |   Indisponiveis: {row["indisponiveis"]}";
        }

        public async Task AlterarStatus(long codigo, eStatus status)
        {
            string sql = $@"UPDATE computador SET status = {(int)status} WHERE codigo = {codigo}";

            await Database.EscreverAsync(sql);
            await PopularComputadores();
        }
        public async Task RemoverComputador(long codigo)
        {
            string sql = $@"DELETE FROM computador WHERE codigo = {codigo}";

            Database.EscreverAsync(sql);
            PopularComputadores();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmComprarComputador frm = new frmComprarComputador(this);

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularComputadores();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var row = ViewComputadores.CurrentRow;
            long codigo = Convert.ToInt64(row.Cells["codigo"].Value);

            if (MessageBox.Show($"Deletar o computador #{codigo}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                RemoverComputador(codigo);
        }

        private async void Computadores_Load(object sender, EventArgs e)
        {
            await PopularComputadores();
        }

        private async void btnManutencao_Click(object sender, EventArgs e)
        {
            var row = ViewComputadores.CurrentRow;

            if (row == null)
                return;

            long codigo = Convert.ToInt64(row.Cells["codigo"].Value);
            eStatus status = (eStatus)Convert.ToInt32(row.Cells["status"].Value);

            if (status == eStatus.Ocupado)
            {
                MessageBox.Show("Esse computador esta em uso. Encerre a sessão antes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (status == eStatus.Livre)
            {
                if (MessageBox.Show($"Colocar o computador #{codigo} em manutenção?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    await AlterarStatus(codigo, eStatus.Indisponivel);
            }
            else
            {
                if (MessageBox.Show($"Liberar o computador #{codigo}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    await AlterarStatus(codigo, eStatus.Livre);
            }
        }

        private void ViewComputadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ViewComputadores.Columns[e.ColumnIndex].Name == "status")
                FormatarStatus(e);
        }

        public static void FormatarStatus(DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value)
                return;

            eStatus status = (eStatus)Convert.ToInt32(e.Value);

            e.Value = status.ToString();
            e.FormattingApplied = true;

            if (status == eStatus.Livre)
                e.CellStyle.BackColor = Color.SeaGreen;
            else if (status == eStatus.Ocupado)
                e.CellStyle.BackColor = Color.DarkOrange;
            else
                e.CellStyle.BackColor = Color.DimGray;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private async void ViewComputadores_Salvou(object sender, EventArgs e)
        {
            await PopularComputadores();
        }
    }
}
