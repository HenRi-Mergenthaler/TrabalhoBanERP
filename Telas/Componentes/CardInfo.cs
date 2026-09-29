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
    public partial class CardInfo : UserControl
    {
        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Valor
        {
            get { return lblValor.Text; }
            set { lblValor.Text = value; }
        }

        public CardInfo()
        {
            InitializeComponent();
        }
    }
}
