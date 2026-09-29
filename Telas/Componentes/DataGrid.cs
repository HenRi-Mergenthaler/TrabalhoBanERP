using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using TrabalhoBan.Helpers;
using TrabalhoBan.Telas.Auxiliares;

public class DataGrid : DataGridView
{
    private bool _permitirEditar = true;

    public string DatabaseName { get; set; }

    public string ColunasSemEdicao { get; set; } = "";

    public event EventHandler Salvou;

    [DefaultValue(true)]
    public bool PermitirEditar
    {
        get { return _permitirEditar; }
        set
        {
            _permitirEditar = value;

            if (!value)
            {
                ReadOnly = true;
                AllowUserToAddRows = false;
                AllowUserToDeleteRows = false;
                MultiSelect = false;
                RowHeadersVisible = false;
                BorderStyle = BorderStyle.None;
                SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }

    public DataGrid()
    {
        BackgroundColor = Color.FromArgb(0, 0, 64);
        GridColor = Color.FromArgb(128, 128, 255);
        EnableHeadersVisualStyles = false;

        ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 192);
        ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
        ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

        DefaultCellStyle.BackColor = Color.Navy;
        DefaultCellStyle.ForeColor = Color.White;
        DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
        DefaultCellStyle.SelectionForeColor = Color.White;

        CellDoubleClick += OpenEditCellForm;
    }

    public void SetDataSource(object dataSource)
    {
        if(string.IsNullOrWhiteSpace(DatabaseName))
            throw new Exception("O DatabaseName do DataGrid não foi informado.");
        DataSource = dataSource;
    }

    public async Task Carregar(string sql)
    {
        DataSource = await Database.LerAsync(sql);
    }

    public void FormatarMoeda(params string[] colunas)
    {
        foreach (string coluna in colunas)
        {
            if (Columns.Contains(coluna))
                Columns[coluna].DefaultCellStyle.Format = "C2";
        }
    }

    public object ValorSelecionado(string coluna)
    {
        if (CurrentRow == null)
            return null;

        return CurrentRow.Cells[coluna].Value;
    }

    public void SelecionarLinha(string coluna, object valor)
    {
        foreach (DataGridViewRow row in Rows)
        {
            if (row.Cells[coluna].Value?.ToString() == valor?.ToString())
            {
                CurrentCell = row.Cells[coluna];
                return;
            }
        }
    }

    public decimal Somar(string coluna)
    {
        decimal total = 0;

        if (DataSource is not DataTable tabela || !tabela.Columns.Contains(coluna))
            return total;

        foreach (DataRow row in tabela.Rows)
        {
            if (row[coluna] != DBNull.Value)
                total += Convert.ToDecimal(row[coluna]);
        }

        return total;
    }

    public void AvisarQueSalvou()
    {
        Salvou?.Invoke(this, EventArgs.Empty);
    }

    private void OpenEditCellForm(object sender, DataGridViewCellEventArgs e)
    {
        if(PermitirEditar && DataSource != null && e.RowIndex >= 0)
        {
            frmEditorDeCelulas frm = new frmEditorDeCelulas(this, e.RowIndex);
            frm.Show();
        }
    }

}
