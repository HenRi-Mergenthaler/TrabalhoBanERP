namespace TrabalhoBan
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button1 = new Button();
            button5 = new Button();
            btnCadastroComputadores = new Button();
            BtnCadastroClientes = new Button();
            btnCadastroFuncionarios = new Button();
            btnAquisicoes = new Button();
            btnProdutos = new Button();
            btnRelatorios = new Button();
            btnSair = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ControlPanel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.Indigo;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(232, 879);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel2.BackgroundImage = Properties.Resources._25559747_7053246_1;
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanel2.Location = new Point(13, 13);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(206, 134);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Controls.Add(btnCadastroComputadores);
            flowLayoutPanel3.Controls.Add(btnAquisicoes);
            flowLayoutPanel3.Controls.Add(btnProdutos);
            flowLayoutPanel3.Controls.Add(BtnCadastroClientes);
            flowLayoutPanel3.Controls.Add(btnCadastroFuncionarios);
            flowLayoutPanel3.Controls.Add(btnRelatorios);
            flowLayoutPanel3.Controls.Add(btnSair);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(13, 153);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(206, 351);
            flowLayoutPanel3.TabIndex = 2;
            flowLayoutPanel3.WrapContents = false;
            button1.BackColor = Color.BlueViolet;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(203, 33);
            button1.TabIndex = 0;
            button1.Text = "DashBoard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button5.BackColor = Color.BlueViolet;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 42);
            button5.Name = "button5";
            button5.Size = new Size(203, 33);
            button5.TabIndex = 1;
            button5.Text = "Sessões";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            btnCadastroComputadores.BackColor = Color.BlueViolet;
            btnCadastroComputadores.BackgroundImageLayout = ImageLayout.None;
            btnCadastroComputadores.FlatAppearance.BorderSize = 0;
            btnCadastroComputadores.FlatStyle = FlatStyle.Flat;
            btnCadastroComputadores.ForeColor = Color.White;
            btnCadastroComputadores.Location = new Point(3, 81);
            btnCadastroComputadores.Name = "btnCadastroComputadores";
            btnCadastroComputadores.Size = new Size(203, 33);
            btnCadastroComputadores.TabIndex = 2;
            btnCadastroComputadores.Text = "Computadores";
            btnCadastroComputadores.UseVisualStyleBackColor = false;
            btnCadastroComputadores.Click += btnCadastroComputadores_Click;
            BtnCadastroClientes.BackColor = Color.BlueViolet;
            BtnCadastroClientes.BackgroundImageLayout = ImageLayout.None;
            BtnCadastroClientes.FlatAppearance.BorderSize = 0;
            BtnCadastroClientes.FlatStyle = FlatStyle.Flat;
            BtnCadastroClientes.ForeColor = Color.White;
            BtnCadastroClientes.Location = new Point(3, 198);
            BtnCadastroClientes.Name = "BtnCadastroClientes";
            BtnCadastroClientes.Size = new Size(203, 33);
            BtnCadastroClientes.TabIndex = 5;
            BtnCadastroClientes.Text = "Cadastro Cliente";
            BtnCadastroClientes.UseVisualStyleBackColor = false;
            BtnCadastroClientes.Click += BtnCadastroClientes_Click;
            btnCadastroFuncionarios.BackColor = Color.BlueViolet;
            btnCadastroFuncionarios.BackgroundImageLayout = ImageLayout.None;
            btnCadastroFuncionarios.FlatAppearance.BorderSize = 0;
            btnCadastroFuncionarios.FlatStyle = FlatStyle.Flat;
            btnCadastroFuncionarios.ForeColor = Color.White;
            btnCadastroFuncionarios.Location = new Point(3, 237);
            btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            btnCadastroFuncionarios.Size = new Size(203, 33);
            btnCadastroFuncionarios.TabIndex = 6;
            btnCadastroFuncionarios.Text = "Cadastro Funcionários";
            btnCadastroFuncionarios.UseVisualStyleBackColor = false;
            btnCadastroFuncionarios.Click += btnCadastroFuncionarios_Click;
            btnAquisicoes.BackColor = Color.BlueViolet;
            btnAquisicoes.BackgroundImageLayout = ImageLayout.None;
            btnAquisicoes.FlatAppearance.BorderSize = 0;
            btnAquisicoes.FlatStyle = FlatStyle.Flat;
            btnAquisicoes.ForeColor = Color.White;
            btnAquisicoes.Location = new Point(3, 120);
            btnAquisicoes.Name = "btnAquisicoes";
            btnAquisicoes.Size = new Size(203, 33);
            btnAquisicoes.TabIndex = 3;
            btnAquisicoes.Text = "Aquisições";
            btnAquisicoes.UseVisualStyleBackColor = false;
            btnAquisicoes.Click += btnAquisicoes_Click;
            btnProdutos.BackColor = Color.BlueViolet;
            btnProdutos.BackgroundImageLayout = ImageLayout.None;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(3, 159);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(203, 33);
            btnProdutos.TabIndex = 4;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            btnRelatorios.BackColor = Color.BlueViolet;
            btnRelatorios.BackgroundImageLayout = ImageLayout.None;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Location = new Point(3, 276);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(203, 33);
            btnRelatorios.TabIndex = 7;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnRelatorios_Click;
            btnSair.BackColor = Color.BlueViolet;
            btnSair.BackgroundImageLayout = ImageLayout.None;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(3, 315);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(203, 33);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.Location = new Point(232, 0);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(1392, 879);
            ControlPanel.TabIndex = 2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1624, 879);
            Controls.Add(ControlPanel);
            Controls.Add(flowLayoutPanel1);
            Name = "Main";
            Text = "hfgh";
            WindowState = FormWindowState.Maximized;
            FormClosed += Main_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnCadastroComputadores;
        private Button BtnCadastroClientes;
        private Button btnCadastroFuncionarios;
        private Button btnAquisicoes;
        private Button btnProdutos;
        private Button btnRelatorios;
        private Button btnSair;
        private ContextMenuStrip contextMenuStrip1;
        private Panel ControlPanel;
    }
}
