namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmCadastroCliente
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            txtCpf = new TextBox();
            groupBox2 = new GroupBox();
            txtNome = new TextBox();
            groupBox3 = new GroupBox();
            txtTelefone = new TextBox();
            groupBox4 = new GroupBox();
            txtEmail = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(296, 287);
            flowLayoutPanel1.TabIndex = 0;
            groupBox1.Controls.Add(txtCpf);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 51);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CPF";
            txtCpf.Dock = DockStyle.Fill;
            txtCpf.Location = new Point(3, 19);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(287, 23);
            txtCpf.TabIndex = 0;
            groupBox2.Controls.Add(txtNome);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 51);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nome";
            txtNome.Dock = DockStyle.Fill;
            txtNome.Location = new Point(3, 19);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(284, 23);
            txtNome.TabIndex = 0;
            groupBox3.Controls.Add(txtTelefone);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 51);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Telefone";
            txtTelefone.Dock = DockStyle.Fill;
            txtTelefone.Location = new Point(3, 19);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(284, 23);
            txtTelefone.TabIndex = 0;
            groupBox4.Controls.Add(txtEmail);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 174);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(290, 51);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Email";
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(3, 19);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 23);
            txtEmail.TabIndex = 0;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 287);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 82);
            panel1.TabIndex = 6;
            button1.BackColor = Color.BlueViolet;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(90, 26);
            button1.Name = "button1";
            button1.Size = new Size(120, 28);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(296, 369);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "frmCadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox txtCpf;
        private GroupBox groupBox2;
        private TextBox txtNome;
        private GroupBox groupBox3;
        private TextBox txtTelefone;
        private GroupBox groupBox4;
        private TextBox txtEmail;
        private Panel panel1;
        private Button button1;
    }
}