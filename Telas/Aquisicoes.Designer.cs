namespace TrabalhoBan.Telas
{
    partial class Aquisicoes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnRemover = new Button();
            btnPesquisar = new Button();
            textBox1 = new TextBox();
            ViewAquisicoes = new DataGrid();
            Codigo = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            fornecedor = new DataGridViewTextBoxColumn();
            nota_fiscal = new DataGridViewTextBoxColumn();
            codigo_computador = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewAquisicoes).BeginInit();
            SuspendLayout();
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1560, 120);
            panel1.TabIndex = 0;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 2;
            label1.Text = "Aquisições";
            btnRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemover.BackColor = Color.BlueViolet;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(1411, 83);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(130, 23);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            btnPesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPesquisar.BackColor = Color.BlueViolet;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(233, 83);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(102, 23);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = Color.BlueViolet;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(15, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 5;
            textBox1.KeyDown += textBox1_KeyDown;
            ViewAquisicoes.BackgroundColor = Color.FromArgb(0, 0, 64);
            ViewAquisicoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ViewAquisicoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ViewAquisicoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewAquisicoes.Columns.AddRange(new DataGridViewColumn[] { Codigo, data, valor, fornecedor, nota_fiscal, codigo_computador });
            ViewAquisicoes.DatabaseName = "aquisicao";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Navy;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            ViewAquisicoes.DefaultCellStyle = dataGridViewCellStyle5;
            ViewAquisicoes.Dock = DockStyle.Fill;
            ViewAquisicoes.EditMode = DataGridViewEditMode.EditOnEnter;
            ViewAquisicoes.EnableHeadersVisualStyles = false;
            ViewAquisicoes.GridColor = Color.FromArgb(128, 128, 255);
            ViewAquisicoes.Location = new Point(0, 120);
            ViewAquisicoes.Margin = new Padding(10);
            ViewAquisicoes.Name = "ViewAquisicoes";
            ViewAquisicoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Blue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            ViewAquisicoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            ViewAquisicoes.Size = new Size(1560, 616);
            ViewAquisicoes.TabIndex = 5;
            ViewAquisicoes.Salvou += ViewAquisicoes_Salvou;
            ViewAquisicoes.AllowUserToAddRows = false;
            ViewAquisicoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Codigo.DataPropertyName = "codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            data.DataPropertyName = "data";
            data.HeaderText = "Data Compra";
            data.Name = "data";
            valor.DataPropertyName = "valor";
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            dataGridViewCellStyle7.Format = "C2";
            valor.DefaultCellStyle = dataGridViewCellStyle7;
            fornecedor.DataPropertyName = "fornecedor";
            fornecedor.HeaderText = "Fornecedor";
            fornecedor.Name = "fornecedor";
            nota_fiscal.DataPropertyName = "nota_fiscal";
            nota_fiscal.HeaderText = "Nota Fiscal";
            nota_fiscal.Name = "nota_fiscal";
            codigo_computador.DataPropertyName = "codigo_computador";
            codigo_computador.HeaderText = "Codigo Computador";
            codigo_computador.Name = "codigo_computador";
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(344, 101);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 9;
            label2.Text = "Double Click na celula para editar.";
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(15, 45);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 19);
            lblTotal.TabIndex = 10;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewAquisicoes);
            Controls.Add(panel1);
            Name = "Aquisicoes";
            Size = new Size(1560, 736);
            Load += Aquisicoes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewAquisicoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPesquisar;
        private TextBox textBox1;
        private Button btnRemover;
        private Label label1;
        private DataGrid ViewAquisicoes;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn fornecedor;
        private DataGridViewTextBoxColumn nota_fiscal;
        private DataGridViewTextBoxColumn codigo_computador;
        private Label label2;
        private Label lblTotal;
    }
}
