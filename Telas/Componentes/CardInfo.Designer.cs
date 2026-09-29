namespace TrabalhoBan.Telas.Componentes
{
    partial class CardInfo
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
            lblValor = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            lblValor.Dock = DockStyle.Fill;
            lblValor.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(10, 35);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(240, 75);
            lblValor.TabIndex = 1;
            lblValor.Text = "0";
            lblValor.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 11F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Margin = new Padding(10);
            Name = "CardInfo";
            Padding = new Padding(10);
            Size = new Size(260, 120);
            ResumeLayout(false);
        }

        #endregion

        private Label lblValor;
        private Label lblTitulo;
    }
}
