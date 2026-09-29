namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmCadastroFuncionario
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
            txtNome = new TextBox();
            groupBox2 = new GroupBox();
            txtLogin = new TextBox();
            groupBox3 = new GroupBox();
            txtSenha = new TextBox();
            panel1 = new Panel();
            btnSalvar = new Button();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.BackColor = Color.Indigo;
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(300, 175);
            flowLayoutPanel1.TabIndex = 7;
            groupBox1.Controls.Add(txtNome);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nome";
            txtNome.Location = new Point(9, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(282, 23);
            txtNome.TabIndex = 0;
            groupBox2.Controls.Add(txtLogin);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 46);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            txtLogin.Location = new Point(9, 17);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(282, 23);
            txtLogin.TabIndex = 0;
            groupBox3.Controls.Add(txtSenha);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(297, 46);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Senha";
            txtSenha.Location = new Point(9, 17);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(282, 23);
            txtSenha.TabIndex = 0;
            txtSenha.UseSystemPasswordChar = true;
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 82);
            panel1.TabIndex = 8;
            btnSalvar.BackColor = Color.BlueViolet;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(92, 28);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(109, 26);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 257);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "frmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionário";
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private GroupBox groupBox2;
        private TextBox txtLogin;
        private GroupBox groupBox3;
        private TextBox txtSenha;
        private Button btnSalvar;
    }
}