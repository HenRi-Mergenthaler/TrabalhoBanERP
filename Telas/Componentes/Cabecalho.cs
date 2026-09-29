using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Componentes
{
    public partial class Cabecalho : UserControl
    {
        public event EventHandler Pesquisar;

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Dica
        {
            get { return lblDica.Text; }
            set { lblDica.Text = value; }
        }

        public bool MostrarPesquisa
        {
            get { return txtPesquisa.Visible; }
            set
            {
                txtPesquisa.Visible = value;
                btnPesquisar.Visible = value;
            }
        }

        [Browsable(false)]
        public string TextoPesquisa
        {
            get { return txtPesquisa.Text.Trim().Replace("'", "''"); }
        }

        public Cabecalho()
        {
            InitializeComponent();
        }

        public Botao AdicionarBotao(string texto, EventHandler click)
        {
            Botao botao = new Botao();
            botao.Text = texto;
            botao.Click += click;

            painelBotoes.Controls.Add(botao);

            return botao;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar?.Invoke(this, e);
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Pesquisar?.Invoke(this, e);
            }
        }
    }
}
