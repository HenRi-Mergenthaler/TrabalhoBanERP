using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Componentes
{
    public class Botao : Button
    {
        public Botao()
        {
            BackColor = Color.BlueViolet;
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(130, 23);
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
        }
    }
}
