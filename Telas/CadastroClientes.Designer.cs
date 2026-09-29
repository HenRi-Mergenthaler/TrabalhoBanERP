namespace TrabalhoBan.Telas
{
    partial class CadastroClientes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnEditar = new Button();
            button1 = new Button();
            btnAdicionarCliente = new Button();
            btnPesquisar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ViewClientes = new DataGridView();
            CPF = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            cadastroClientesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cadastroClientesBindingSource).BeginInit();
            SuspendLayout();
            dataGridView1.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1428, 757);
            dataGridView1.TabIndex = 0;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAdicionarCliente);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 115);
            panel1.TabIndex = 1;
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.BlueViolet;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(1012, 72);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.BlueViolet;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1148, 72);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 4;
            button1.Text = "Remover ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            btnAdicionarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarCliente.BackColor = Color.BlueViolet;
            btnAdicionarCliente.FlatAppearance.BorderSize = 0;
            btnAdicionarCliente.FlatStyle = FlatStyle.Flat;
            btnAdicionarCliente.ForeColor = Color.White;
            btnAdicionarCliente.Location = new Point(1284, 72);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(130, 23);
            btnAdicionarCliente.TabIndex = 3;
            btnAdicionarCliente.Text = "Adicionar Cliente";
            btnAdicionarCliente.UseVisualStyleBackColor = false;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            btnPesquisar.BackColor = Color.BlueViolet;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(241, 72);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(102, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
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
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Clientes";
            ViewClientes.AllowUserToAddRows = false;
            ViewClientes.BackgroundColor = Color.FromArgb(0, 0, 64);
            ViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewClientes.Columns.AddRange(new DataGridViewColumn[] { CPF, Nome, Telefone, Email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            ViewClientes.Dock = DockStyle.Fill;
            ViewClientes.EnableHeadersVisualStyles = false;
            ViewClientes.GridColor = Color.FromArgb(128, 128, 255);
            ViewClientes.Location = new Point(0, 115);
            ViewClientes.Margin = new Padding(10);
            ViewClientes.Name = "ViewClientes";
            ViewClientes.ReadOnly = true;
            ViewClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Blue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewClientes.Size = new Size(1428, 642);
            ViewClientes.TabIndex = 2;
            ViewClientes.CellDoubleClick += ViewClientes_CellDoubleClick;
            CPF.DataPropertyName = "cpf";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            CPF.Width = 150;
            Nome.DataPropertyName = "nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            Telefone.DataPropertyName = "telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 150;
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 200;
            cadastroClientesBindingSource.DataSource = typeof(CadastroClientes);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewClientes);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "CadastroClientes";
            Size = new Size(1428, 757);
            Load += CadastroClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)cadastroClientesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btnAdicionarCliente;
        private Button btnPesquisar;
        private DataGridView ViewClientes;
        private BindingSource cadastroClientesBindingSource;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private Button button1;
        private Button btnEditar;
    }
}
