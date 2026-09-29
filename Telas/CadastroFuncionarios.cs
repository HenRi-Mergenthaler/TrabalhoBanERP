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
using TrabalhoBan.Tabelas;
using TrabalhoBan.Telas.Auxiliares;

namespace TrabalhoBan.Telas
{
    public partial class CadastroFuncionarios : UserControl
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }
        private async void button1_Click_1(object sender, EventArgs e)
        {
            await PopularGridFuncionarios();
        }

        public async Task PopularGridFuncionarios()
        {
            var querySql = @"SELECT * FROM funcionario";

            string pesquisa = textBox1.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(pesquisa))
                querySql += $@" WHERE nome ILIKE '%{pesquisa}%' OR login ILIKE '%{pesquisa}%'";

            querySql += " ORDER BY codigo";

            ViewFuncionarios.DataSource = await Database.LerAsync(querySql);
        }

        public async Task RemoverFuncionario(long codigo)
        {
            string sql = $@"DELETE FROM funcionario WHERE codigo = {codigo}";

            Database.EscreverAsync(sql);
            PopularGridFuncionarios();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario(this);

            frm.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var row = ViewFuncionarios.CurrentRow;
            long codigo = Convert.ToInt64(row.Cells["codigo"].Value);
            string nome = row.Cells["nome"].Value.ToString();

            if (codigo == UsuarioLogado.Codigo)
            {
                MessageBox.Show("Você não pode remover o funcionario que esta logado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Deletar o funcionario {nome}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                RemoverFuncionario(codigo);
        }

        private async void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
            await PopularGridFuncionarios();
        }

        private void ViewFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ViewFuncionarios.Columns[e.ColumnIndex].DataPropertyName == "senha" && e.Value != null)
            {
                e.Value = "******";
                e.FormattingApplied = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private async void ViewFuncionarios_Salvou(object sender, EventArgs e)
        {
            await PopularGridFuncionarios();
        }
    }
}
