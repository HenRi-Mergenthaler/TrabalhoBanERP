using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmQuantidade : Form
    {
        public frmQuantidade()
        {
            InitializeComponent();
        }

        public static int? Perguntar(string titulo, string texto)
        {
            frmQuantidade frm = new frmQuantidade();

            frm.Text = titulo;
            frm.campoQuantidade.Text = texto;

            if (frm.ShowDialog() == DialogResult.OK)
                return (int)frm.campoQuantidade.Valor;

            return null;
        }
    }
}
