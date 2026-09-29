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
    public partial class CadastroClientes : UserControl
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            await PopularGridClientes();
        }

        public async Task PopularGridClientes()
        {
            var querySql = @"SELECT * FROM cliente";

            string pesquisa = textBox1.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(pesquisa))
                querySql += $@" WHERE nome ILIKE '%{pesquisa}%' OR CAST(cpf AS TEXT) LIKE '%{pesquisa}%'";

            querySql += " ORDER BY nome";

            ViewClientes.DataSource = await Database.LerAsync(querySql);
        }

        public async Task RemoverCliente(long cpf)
        {
            string sql = $@"DELETE FROM cliente WHERE cpf = {cpf}";

            Database.EscreverAsync(sql);
            PopularGridClientes();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frm = new frmCadastroCliente(this);

            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row = ViewClientes.CurrentRow;
            long cpfToDelete = Convert.ToInt64(row.Cells["cpf"].Value);
            string nomeCliente = row.Cells["nome"].Value.ToString();

            if(MessageBox.Show($"Deletar o cliente {nomeCliente}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                RemoverCliente(cpfToDelete);
        }

        private async void CadastroClientes_Load(object sender, EventArgs e)
        {
            await PopularGridClientes();
        }

        private void EditarCliente()
        {
            var row = ViewClientes.CurrentRow;

            if (row == null)
                return;

            frmCadastroCliente frm = new frmCadastroCliente(this, row);

            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }

        private void ViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                EditarCliente();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar.PerformClick();
        }
    }
}
