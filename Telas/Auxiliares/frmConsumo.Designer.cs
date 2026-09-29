namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmConsumo
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
            campoProduto = new Componentes.CampoLista();
            campoQuantidade = new Componentes.CampoNumero();
            lblTotal = new Label();
            panel1 = new Panel();
            btnAdicionar = new Componentes.Botao();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.Controls.Add(campoProduto);
            flowLayoutPanel1.Controls.Add(campoQuantidade);
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(396, 150);
            flowLayoutPanel1.TabIndex = 0;
            campoProduto.ForeColor = Color.White;
            campoProduto.Location = new Point(3, 3);
            campoProduto.Name = "campoProduto";
            campoProduto.Size = new Size(390, 51);
            campoProduto.TabIndex = 0;
            campoProduto.TabStop = false;
            campoProduto.Text = "Produto";
            campoProduto.ItemSelecionado += campoProduto_ItemSelecionado;
            campoQuantidade.ForeColor = Color.White;
            campoQuantidade.Location = new Point(3, 60);
            campoQuantidade.Minimo = new decimal(new int[] { 1, 0, 0, 0 });
            campoQuantidade.Name = "campoQuantidade";
            campoQuantidade.Size = new Size(390, 51);
            campoQuantidade.TabIndex = 1;
            campoQuantidade.TabStop = false;
            campoQuantidade.Text = "Quantidade";
            campoQuantidade.ValorAlterado += campoQuantidade_ValorAlterado;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(3, 117);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total: R$ 0,00";
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 60);
            panel1.TabIndex = 1;
            btnAdicionar.Location = new Point(128, 16);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(140, 28);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(396, 210);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Consumo";
            Load += frmConsumo_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Componentes.CampoLista campoProduto;
        private Componentes.CampoNumero campoQuantidade;
        private Label lblTotal;
        private Panel panel1;
        private Componentes.Botao btnAdicionar;
    }
}
