namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmEncerrarSessao
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
            lblResumo = new Label();
            chkCorujao = new CheckBox();
            campoPagamento = new Componentes.CampoLista();
            lblTotal = new Label();
            panel1 = new Panel();
            btnConfirmar = new Componentes.Botao();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(chkCorujao);
            flowLayoutPanel1.Controls.Add(campoPagamento);
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(420, 350);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            groupBox1.Controls.Add(lblResumo);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(400, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resumo";
            lblResumo.Dock = DockStyle.Fill;
            lblResumo.Font = new Font("Segoe UI", 10F);
            lblResumo.ForeColor = Color.White;
            lblResumo.Location = new Point(8, 24);
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(384, 148);
            lblResumo.TabIndex = 0;
            lblResumo.Text = "Carregando...";
            chkCorujao.AutoSize = true;
            chkCorujao.ForeColor = Color.White;
            chkCorujao.Location = new Point(8, 194);
            chkCorujao.Name = "chkCorujao";
            chkCorujao.Size = new Size(160, 19);
            chkCorujao.TabIndex = 1;
            chkCorujao.Text = "Cobrar como Corujão";
            chkCorujao.UseVisualStyleBackColor = true;
            chkCorujao.CheckedChanged += chkCorujao_CheckedChanged;
            campoPagamento.ForeColor = Color.White;
            campoPagamento.Location = new Point(8, 219);
            campoPagamento.Name = "campoPagamento";
            campoPagamento.Size = new Size(400, 51);
            campoPagamento.TabIndex = 2;
            campoPagamento.TabStop = false;
            campoPagamento.Text = "Forma de Pagamento";
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(8, 283);
            lblTotal.Margin = new Padding(3, 10, 3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 32);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: R$ 0,00";
            panel1.Controls.Add(btnConfirmar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 60);
            panel1.TabIndex = 1;
            btnConfirmar.Enabled = false;
            btnConfirmar.Location = new Point(125, 14);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(170, 32);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar Pagamento";
            btnConfirmar.Click += btnConfirmar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(420, 410);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEncerrarSessao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encerrar Sessão";
            Load += frmEncerrarSessao_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label lblResumo;
        private CheckBox chkCorujao;
        private Componentes.CampoLista campoPagamento;
        private Label lblTotal;
        private Panel panel1;
        private Componentes.Botao btnConfirmar;
    }
}
