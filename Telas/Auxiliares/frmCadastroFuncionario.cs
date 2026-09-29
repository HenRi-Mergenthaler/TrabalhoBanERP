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
    public partial class frmCadastroFuncionario : Form
    {
        CadastroFuncionarios funcionarios;

        public frmCadastroFuncionario(CadastroFuncionarios funcionarios)
        {
            InitializeComponent();
            this.funcionarios = funcionarios;
        }

        private async void SalvarFuncionario()
        {
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            string sql = $@"INSERT INTO funcionario (nome, login, senha)
                            VALUES ('{nome}', '{login}', '{senha}');";

            await Database.EscreverAsync(sql);
            funcionarios.PopularGridFuncionarios();
        }
        private async Task<bool> ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha nome, login e senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSenha.Text.Length < 4)
            {
                MessageBox.Show("A senha precisa ter pelo menos 4 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string login = txtLogin.Text.Trim().Replace("'", "''");
            DataTable tabela = await Database.LerAsync($"SELECT codigo FROM funcionario WHERE login = '{login}'");

            if (tabela.Rows.Count > 0)
            {
                MessageBox.Show("Ja existe um funcionario com esse login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!await ValidarCampos())
                return;

            SalvarFuncionario();
            this.Close();
        }
    }
}
