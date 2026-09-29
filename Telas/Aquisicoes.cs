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

namespace TrabalhoBan.Telas
{
    public partial class Aquisicoes : UserControl
    {
        public Aquisicoes()
        {
            InitializeComponent();
        }
        public async Task PopularAquisicoes()
        {
            string sql = @"SELECT * FROM aquisicao";

            string pesquisa = textBox1.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(pesquisa))
                sql += $@" WHERE fornecedor ILIKE '%{pesquisa}%' OR CAST(nota_fiscal AS TEXT) LIKE '%{pesquisa}%'";

            sql += " ORDER BY data DESC";

            ViewAquisicoes.SetDataSource(await Database.LerAsync(sql));

            lblTotal.Text = $"Total investido: {SomarValores():C2}   |   {ViewAquisicoes.Rows.Count} aquisições";
        }

        private decimal SomarValores()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in ViewAquisicoes.Rows)
            {
                if (row.Cells["valor"].Value != null && row.Cells["valor"].Value != DBNull.Value)
                    total += Convert.ToDecimal(row.Cells["valor"].Value);
            }

            return total;
        }

        private async void Aquisicoes_Load(object sender, EventArgs e)
        {
            await PopularAquisicoes();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar.PerformClick();
        }
        public async Task RemoverAquisição(long codigo)
        {
            string sql = $@"DELETE FROM aquisicao WHERE codigo = {codigo}";

            Database.EscreverAsync(sql);
            PopularAquisicoes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PopularAquisicoes();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var row = ViewAquisicoes.CurrentRow;
            long codigo = Convert.ToInt64(row.Cells["codigo"].Value);

            if (MessageBox.Show($"Deletar a aquisição #{codigo}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                RemoverAquisição(codigo);
        }

        private async void ViewAquisicoes_Salvou(object sender, EventArgs e)
        {
            await PopularAquisicoes();
        }
    }
}
