using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Componentes
{
    public class CampoData : GroupBox
    {
        private DateTimePicker data = new DateTimePicker();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Valor
        {
            get { return data.Value; }
            set { data.Value = value; }
        }

        public CampoData()
        {
            ForeColor = Color.White;
            Size = new Size(200, 51);

            data.Dock = DockStyle.Fill;
            data.Format = DateTimePickerFormat.Short;
            Controls.Add(data);
        }
    }
}
