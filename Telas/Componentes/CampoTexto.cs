using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Componentes
{
    public class CampoTexto : GroupBox
    {
        private TextBox txt = new TextBox();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Valor
        {
            get { return txt.Text.Trim(); }
            set { txt.Text = value; }
        }

        public string ValorSql
        {
            get { return Valor.Replace("'", "''"); }
        }

        public bool Senha
        {
            get { return txt.UseSystemPasswordChar; }
            set { txt.UseSystemPasswordChar = value; }
        }

        public bool SomenteLeitura
        {
            get { return txt.ReadOnly; }
            set { txt.ReadOnly = value; }
        }

        public int TamanhoMaximo
        {
            get { return txt.MaxLength; }
            set { txt.MaxLength = value; }
        }

        public CampoTexto()
        {
            ForeColor = Color.White;
            Size = new Size(290, 51);

            txt.Dock = DockStyle.Fill;
            Controls.Add(txt);
        }
    }
}
