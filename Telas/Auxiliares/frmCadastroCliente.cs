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

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmCadastroCliente : Form
    {
        CadastroClientes clientes;
        long? cpfEdicao = null;

        public frmCadastroCliente(CadastroClientes clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        public frmCadastroCliente(CadastroClientes clientes, DataGridViewRow row) : this(clientes)
        {
            cpfEdicao = Convert.ToInt64(row.Cells["CPF"].Value);

            txtCpf.Text = cpfEdicao.ToString();
            txtCpf.ReadOnly = true;
            txtNome.Text = row.Cells["Nome"].Value?.ToString();
            txtTelefone.Text = row.Cells["Telefone"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            Text = "Editar Cliente";
        }

        private bool ValidarCampos()
        {
            string cpf = txtCpf.Text.Trim();

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                MessageBox.Show("O CPF precisa ter 11 numeros (sem ponto e traço).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefone.Text) && !txtTelefone.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show("O telefone deve ter so numeros.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void SalvarCliente()
        {
            long cpf;
            long.TryParse(txtCpf.Text, out cpf);
            string nome = txtNome.Text;
            long telefone;
            long.TryParse(txtTelefone.Text, out telefone);
            string email = txtEmail.Text;

            string sql = $@"INSERT INTO cliente (cpf, nome, telefone, email)
                            VALUES ({cpf}, '{nome}', {telefone}, '{email}');";

            if (cpfEdicao != null)
                sql = $@"UPDATE cliente SET nome = '{nome}', telefone = {telefone}, email = '{email}'
                         WHERE cpf = {cpfEdicao};";

            await Database.EscreverAsync(sql);
            clientes.PopularGridClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            SalvarCliente();
            this.Close();
        }
    }
}
