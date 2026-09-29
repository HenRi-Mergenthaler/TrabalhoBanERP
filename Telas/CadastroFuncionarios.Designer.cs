namespace TrabalhoBan.Telas
{
    partial class CadastroFuncionarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnRemover = new Button();
            btnAdicionar = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ViewFuncionarios = new DataGrid();
            codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewFuncionarios).BeginInit();
            SuspendLayout();
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 115);
            panel1.TabIndex = 1;
            btnRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemover.BackColor = Color.BlueViolet;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(1148, 72);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(130, 23);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.BackColor = Color.BlueViolet;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(1284, 72);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(130, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar Funcionário";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            button1.BackColor = Color.BlueViolet;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(241, 72);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 2;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            textBox1.BackColor = Color.BlueViolet;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(23, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(280, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Funcionários";
            ViewFuncionarios.BackgroundColor = Color.FromArgb(0, 0, 64);
            ViewFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewFuncionarios.Columns.AddRange(new DataGridViewColumn[] { codigo, Nome, Telefone, Email });
            ViewFuncionarios.DatabaseName = "funcionario";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            ViewFuncionarios.Dock = DockStyle.Fill;
            ViewFuncionarios.EnableHeadersVisualStyles = false;
            ViewFuncionarios.GridColor = Color.FromArgb(128, 128, 255);
            ViewFuncionarios.Location = new Point(0, 115);
            ViewFuncionarios.Margin = new Padding(10);
            ViewFuncionarios.Name = "ViewFuncionarios";
            ViewFuncionarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Blue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ViewFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ViewFuncionarios.Size = new Size(1428, 642);
            ViewFuncionarios.TabIndex = 3;
            ViewFuncionarios.Salvou += ViewFuncionarios_Salvou;
            ViewFuncionarios.AllowUserToAddRows = false;
            ViewFuncionarios.CellFormatting += ViewFuncionarios_CellFormatting;
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Codigo";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 150;
            Nome.DataPropertyName = "nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 200;
            Telefone.DataPropertyName = "login";
            Telefone.HeaderText = "Login";
            Telefone.Name = "Telefone";
            Telefone.Width = 150;
            Email.DataPropertyName = "senha";
            Email.HeaderText = "Senha";
            Email.Name = "Email";
            Email.Width = 200;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(349, 90);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 5;
            label2.Text = "Double Click na celula para editar.";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewFuncionarios);
            Controls.Add(panel1);
            Name = "CadastroFuncionarios";
            Size = new Size(1428, 757);
            Load += CadastroFuncionarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btnAdicionar;
        private Button button1;
        private Button btnRemover;
        private DataGrid ViewFuncionarios;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private Label label2;
    }
}
