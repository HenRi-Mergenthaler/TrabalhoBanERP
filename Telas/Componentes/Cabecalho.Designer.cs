namespace TrabalhoBan.Telas.Componentes
{
    partial class Cabecalho
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
            lblTitulo = new Label();
            txtPesquisa = new TextBox();
            btnPesquisar = new Botao();
            lblDica = new Label();
            painelBotoes = new FlowLayoutPanel();
            SuspendLayout();
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(79, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            txtPesquisa.BackColor = Color.BlueViolet;
            txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisa.ForeColor = Color.White;
            txtPesquisa.Location = new Point(23, 72);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(212, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            btnPesquisar.Location = new Point(241, 72);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(102, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            lblDica.AutoSize = true;
            lblDica.ForeColor = Color.White;
            lblDica.Location = new Point(23, 97);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(0, 15);
            lblDica.TabIndex = 3;
            painelBotoes.AutoSize = true;
            painelBotoes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            painelBotoes.Dock = DockStyle.Right;
            painelBotoes.FlowDirection = FlowDirection.RightToLeft;
            painelBotoes.Location = new Point(990, 0);
            painelBotoes.Name = "painelBotoes";
            painelBotoes.Padding = new Padding(0, 69, 10, 0);
            painelBotoes.Size = new Size(10, 115);
            painelBotoes.TabIndex = 4;
            painelBotoes.WrapContents = false;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            Controls.Add(painelBotoes);
            Controls.Add(lblTitulo);
            Controls.Add(txtPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(lblDica);
            Name = "Cabecalho";
            Size = new Size(1000, 115);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtPesquisa;
        private Botao btnPesquisar;
        private Label lblDica;
        private FlowLayoutPanel painelBotoes;
    }
}
