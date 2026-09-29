using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoBan.Telas.Componentes
{
    public class CampoLista : GroupBox
    {
        private ComboBox combo = new ComboBox();

        public event EventHandler ItemSelecionado;

        public object ValorSelecionado
        {
            get
            {
                if (string.IsNullOrEmpty(combo.ValueMember))
                    return combo.SelectedItem;

                return combo.SelectedValue;
            }
        }

        public DataRow LinhaSelecionada
        {
            get { return (combo.SelectedItem as DataRowView)?.Row; }
        }

        public int Quantidade
        {
            get { return combo.Items.Count; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IndiceSelecionado
        {
            get { return combo.SelectedIndex; }
            set { combo.SelectedIndex = value; }
        }

        public CampoLista()
        {
            ForeColor = Color.White;
            Size = new Size(290, 51);

            combo.Dock = DockStyle.Fill;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            Controls.Add(combo);
        }

        public void Carregar(DataTable tabela, string colunaTexto, string colunaValor)
        {
            combo.DisplayMember = colunaTexto;
            combo.ValueMember = colunaValor;
            combo.DataSource = tabela;
        }

        public void CarregarEnum<T>() where T : Enum
        {
            combo.DataSource = Enum.GetValues(typeof(T));
        }

        public void CarregarItens(params string[] itens)
        {
            combo.Items.Clear();
            combo.Items.AddRange(itens);
            combo.SelectedIndex = 0;
        }

        public void Selecionar(object valor)
        {
            if (string.IsNullOrEmpty(combo.ValueMember))
                combo.SelectedItem = valor;
            else
                combo.SelectedValue = valor;
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemSelecionado?.Invoke(this, e);
        }
    }
}
