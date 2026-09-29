using TrabalhoBan.Tabelas;
using TrabalhoBan.Telas;

namespace TrabalhoBan
{
    public partial class Main : Form
    {
        private Control _ctrlAtivo;

        public Main()
        {
            InitializeComponent();

            Text = $"LanHouse M - Funcionário: {UsuarioLogado.Nome}";
            AbrirTela(new Dashboard());
        }

        private void AbrirTela(Control tela)
        {
            if (_ctrlAtivo != null && _ctrlAtivo.Name == tela.Name)
                return;

            _ctrlAtivo = tela;

            ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(tela);
            tela.Dock = DockStyle.Fill;
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void BtnCadastroClientes_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastroClientes());
        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastroFuncionarios());
        }

        private void btnCadastroComputadores_Click(object sender, EventArgs e)
        {
            AbrirTela(new Computadores());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirTela(new Dashboard());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirTela(new Sessoes());
        }

        private void btnAquisicoes_Click(object sender, EventArgs e)
        {
            AbrirTela(new Aquisicoes());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirTela(new CadastroProduto());
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            AbrirTela(new ctrlRelatorios());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Application.OpenForms["Login"]?.Show();

            FormClosed -= Main_FormClosed;
            this.Close();
        }
    }
}
