namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmQuantidade
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
            campoQuantidade = new Componentes.CampoNumero();
            btnOk = new Componentes.Botao();
            SuspendLayout();
            campoQuantidade.ForeColor = Color.White;
            campoQuantidade.Location = new Point(12, 12);
            campoQuantidade.Minimo = new decimal(new int[] { 1, 0, 0, 0 });
            campoQuantidade.Name = "campoQuantidade";
            campoQuantidade.Size = new Size(330, 51);
            campoQuantidade.TabIndex = 0;
            campoQuantidade.TabStop = false;
            campoQuantidade.Text = "Quantidade";
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(117, 75);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 28);
            btnOk.TabIndex = 1;
            btnOk.Text = "Confirmar";
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(354, 115);
            Controls.Add(btnOk);
            Controls.Add(campoQuantidade);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmQuantidade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quantidade";
            ResumeLayout(false);
        }

        #endregion

        private Componentes.CampoNumero campoQuantidade;
        private Componentes.Botao btnOk;
    }
}
