using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoBan.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace TrabalhoBan.Telas.Auxiliares
{
    public partial class frmEditorDeCelulas : Form
    {
        private string _databaseName;
        private long? _selectedRowId = null;
        private DataGrid _gridView;

        public frmEditorDeCelulas(DataGrid gridView, int? rowIndex = null)
        {
            InitializeComponent();
            _gridView = gridView;

            DataRow row = null;
            if (rowIndex != null)
                row = (gridView.Rows[rowIndex.Value].DataBoundItem as DataRowView)?.Row;

            PopulateControl(gridView.DataSource as DataTable, row);
            _databaseName = gridView.DatabaseName;
        }

        private void PopulateControl(DataTable table, DataRow row)
        {
            if (table.Rows.Count == 0)
                return;

            foreach (DataColumn column in table.Columns)
            {
                if (column.ColumnName == "Codigo" || column.ColumnName == "codigo" || column.ColumnName == "CPF" || ColunaSomenteLeitura(column.ColumnName))
                    continue;
                string nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(column.ColumnName);
                if(row != null)
                {
                    AddGroup(CriarGroup(nome, GetEType(column), row[column.ColumnName]));
                    _selectedRowId = Convert.ToInt64(row["Codigo"]);
                }
                else
                {
                    AddGroup(CriarGroup<string>(nome, GetEType(column), null));
                }
            }
        }

        private bool ColunaSomenteLeitura(string nome)
        {
            foreach (string coluna in _gridView.ColunasSemEdicao.Split(','))
            {
                if (coluna.Trim().Equals(nome, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        private void AddGroup(Control control)
        {
            flowLayoutPanel1.Controls.Add(control);
        }

        private eInputType GetEType(DataColumn column)
        {
            if (column.DataType == typeof(string))
                return eInputType.Texto;

            if (column.DataType == typeof(int) ||
                column.DataType == typeof(short) ||
                column.DataType == typeof(Single) ||
                column.DataType == typeof(long) ||
                column.DataType == typeof(decimal) ||
                column.DataType == typeof(double))
                return eInputType.Numero;

            if (column.DataType == typeof(DateTime))
                return eInputType.Data;

            throw new Exception($"Tipo não suportado: {column.DataType.Name}");
        }

        private GroupBox CriarGroup<T>(string nome, eInputType tipo, T? value)
        {
            GroupBox group = new GroupBox();

            group.Name = nome;
            group.Text = nome;
            group.ForeColor = Color.White;
            group.Size = new Size(261, 51);

            bool vazio = value == null || value is DBNull;

            switch (tipo)
            {
                case eInputType.Texto:
                    group.Controls.Add(CriarText($"{nome}", vazio ? "" : value.ToString()));
                    break;
                case eInputType.Numero:
                    int casas = value is float || value is double || value is decimal ? 2 : 0;
                    group.Controls.Add(CriarNumero($"{nome}", vazio ? 0 : Convert.ToDecimal(value), casas));
                    break;
                case eInputType.Data:
                    group.Controls.Add(CriarData($"{nome}", vazio ? DateTime.Now : Convert.ToDateTime(value)));
                    break;
            }

            if (vazio)
                group.Tag = GetValueControl(group);

            return group;
        }

        public async Task SalvarMudancas()
        {
            string campos = "";
            string valores = "";

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                string valor = GetValueControl(ctrl);

                if (valor == null)
                    continue;

                campos += $"{ctrl.Name}, ";
                valores += $"'{valor}', ";
            }

            campos = campos.TrimEnd(',', ' ');
            valores = valores.TrimEnd(',', ' ');

            if (campos == "")
            {
                this.Close();
                return;
            }

            string sql;

            if (_selectedRowId == null)
            {
                sql = $"INSERT INTO {_databaseName} ({campos}) VALUES ({valores})";
            }
            else
            {
                string alteracoes = "";

                foreach (Control ctrl in flowLayoutPanel1.Controls)
                {
                    string valor = GetValueControl(ctrl);

                    if (valor == null)
                        continue;

                    alteracoes += $"{ctrl.Name} = '{valor}', ";
                }

                alteracoes = alteracoes.TrimEnd(',', ' ');

                sql = $"UPDATE {_databaseName} SET {alteracoes} WHERE codigo = {_selectedRowId}";
            }

            try
            {
                await Database.EscreverAsync(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _gridView.AvisarQueSalvou();
            this.Close();
        }

        public string GetValueControl(Control group)
        {
            string valor = null;
            Control ctrl = group.Controls[0];

            if (ctrl is TextBox)
                valor = ((TextBox)ctrl).Text.Replace("'", "''");

            if (ctrl is DateTimePicker)
                valor = ((DateTimePicker)ctrl).Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (ctrl is NumericUpDown)
                valor = ((NumericUpDown)ctrl).Value.ToString(CultureInfo.InvariantCulture);

            if (group.Tag != null && group.Tag.ToString() == valor)
                return null;

            return valor;
        }

        private TextBox CriarText(string nome, string value)
        {
            TextBox text = new TextBox();

            text.Name = nome;
            text.Size = new Size(249, 23);
            text.Location = new Point(6, 22);
            text.Text = value;

            return text;
        }

        private NumericUpDown CriarNumero(string nome, decimal value, int casasDecimais)
        {
            NumericUpDown numero = new NumericUpDown();

            numero.Name = nome;
            numero.Size = new Size(249, 23);
            numero.Location = new Point(6, 22);
            numero.Minimum = -999999999999;
            numero.Maximum = 999999999999;
            numero.DecimalPlaces = casasDecimais;
            numero.Value = value;

            return numero;
        }

        private DateTimePicker CriarData(string nome, DateTime value)
        {
            DateTimePicker data = new DateTimePicker();

            data.Name = nome;
            data.Size = new Size(249, 23);
            data.Location = new Point(6, 22);
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "dd/MM/yyyy HH:mm";
            data.Value = value;

            return data;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            await SalvarMudancas();
            button1.Enabled = true;
        }

        private enum eInputType
        {
            Texto,
            Data,
            Numero
        }
    }
}
