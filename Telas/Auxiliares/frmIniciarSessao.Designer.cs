namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmIniciarSessao
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
            campoCliente = new TrabalhoBan.Telas.Componentes.CampoLista();
            campoComputador = new TrabalhoBan.Telas.Componentes.CampoLista();
            panel1 = new Panel();
            btnIniciar = new TrabalhoBan.Telas.Componentes.Botao();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.Controls.Add(campoCliente);
            flowLayoutPanel1.Controls.Add(campoComputador);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 118);
            flowLayoutPanel1.TabIndex = 0;
            campoCliente.ForeColor = Color.White;
            campoCliente.Location = new Point(3, 3);
            campoCliente.Name = "campoCliente";
            campoCliente.Size = new Size(390, 51);
            campoCliente.TabIndex = 0;
            campoCliente.TabStop = false;
            campoCliente.Text = "Cliente";
            campoComputador.ForeColor = Color.White;
            campoComputador.Location = new Point(3, 60);
            campoComputador.Name = "campoComputador";
            campoComputador.Size = new Size(390, 51);
            campoComputador.TabIndex = 1;
            campoComputador.TabStop = false;
            campoComputador.Text = "Computador Livres";
            panel1.Controls.Add(btnIniciar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 60);
            panel1.TabIndex = 1;
            btnIniciar.BackColor = Color.BlueViolet;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(128, 16);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(140, 28);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sessão";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(396, 178);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmIniciarSessao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sessão";
            Load += frmIniciarSessao_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Componentes.CampoLista campoCliente;
        private Componentes.CampoLista campoComputador;
        private Panel panel1;
        private Componentes.Botao btnIniciar;
    }
}
