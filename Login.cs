using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoBan.Tabelas;
using System.IO;
using TrabalhoBan.Helpers;

namespace TrabalhoBan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            textBox1.Text = GetUsuarioTemp();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim().Replace("'", "''");
            string senha = textBox2.Text.Replace("'", "''");

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Informe o usuario e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $@"SELECT codigo, nome FROM funcionario
                            WHERE login = '{login}' AND senha = '{senha}'";

            DataTable tabela;

            button1.Enabled = false;
            try
            {
                tabela = await Database.LerAsync(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                button1.Enabled = true;
            }

            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Usuario ou senha invalidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
                return;
            }

            UsuarioLogado.Codigo = Convert.ToInt64(tabela.Rows[0]["codigo"]);
            UsuarioLogado.Nome = tabela.Rows[0]["nome"].ToString();
            SalvarUsuarioTemp();

            Main form = new Main();
            form.Show();

            textBox2.Clear();
            this.Hide();
        }

        private void SalvarUsuarioTemp()
        {
            string pasta = Path.Combine(Path.GetTempPath(), "ERP LAN");
            string path = Path.Combine(pasta, "temp.txt");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            if (!File.Exists(path))
                File.Create(path).Close();

            string line;

            using (StreamReader str = new StreamReader(path))
            {
                line = str.ReadLine();
            }

            if (line != UsuarioLogado.Nome)
            {
                using (StreamWriter wrt = new StreamWriter(path, false))
                {
                    wrt.WriteLine(UsuarioLogado.Nome);
                }
            }
        }
        
        private string GetUsuarioTemp()
        {
            string pasta = Path.Combine(Path.GetTempPath(), "ERP LAN");
            string path = Path.Combine(pasta, "temp.txt");

            if (!File.Exists(path))
                return "";

            return new StreamReader(path).ReadLine(); 
        }
    }
}
