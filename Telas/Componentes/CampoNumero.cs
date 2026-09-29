using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Componentes
{
    public class CampoNumero : GroupBox
    {
        private NumericUpDown numero = new NumericUpDown();

        public event EventHandler ValorAlterado;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Valor
        {
            get { return numero.Value; }
            set { numero.Value = value; }
        }

        public string ValorSql
        {
            get { return numero.Value.ToString(CultureInfo.InvariantCulture); }
        }

        public int CasasDecimais
        {
            get { return numero.DecimalPlaces; }
            set { numero.DecimalPlaces = value; }
        }

        public decimal Minimo
        {
            get { return numero.Minimum; }
            set { numero.Minimum = value; }
        }

        public decimal Maximo
        {
            get { return numero.Maximum; }
            set { numero.Maximum = value; }
        }

        public CampoNumero()
        {
            ForeColor = Color.White;
            Size = new Size(290, 51);

            numero.Dock = DockStyle.Fill;
            numero.Maximum = 1000000;
            numero.ThousandsSeparator = true;
            numero.ValueChanged += numero_ValueChanged;
            Controls.Add(numero);
        }

        private void numero_ValueChanged(object sender, EventArgs e)
        {
            ValorAlterado?.Invoke(this, e);
        }
    }
}
