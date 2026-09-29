namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmCadastroProduto
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
            campoNome = new Componentes.CampoTexto();
            campoCategoria = new Componentes.CampoLista();
            campoPreco = new Componentes.CampoNumero();
            campoEstoque = new Componentes.CampoNumero();
            panel1 = new Panel();
            btnSalvar = new Componentes.Botao();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            flowLayoutPanel1.Controls.Add(campoNome);
            flowLayoutPanel1.Controls.Add(campoCategoria);
            flowLayoutPanel1.Controls.Add(campoPreco);
            flowLayoutPanel1.Controls.Add(campoEstoque);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(296, 232);
            flowLayoutPanel1.TabIndex = 0;
            campoNome.ForeColor = Color.White;
            campoNome.Location = new Point(3, 3);
            campoNome.Name = "campoNome";
            campoNome.Size = new Size(290, 51);
            campoNome.TabIndex = 0;
            campoNome.TabStop = false;
            campoNome.TamanhoMaximo = 100;
            campoNome.Text = "Nome";
            campoCategoria.ForeColor = Color.White;
            campoCategoria.Location = new Point(3, 60);
            campoCategoria.Name = "campoCategoria";
            campoCategoria.Size = new Size(290, 51);
            campoCategoria.TabIndex = 1;
            campoCategoria.TabStop = false;
            campoCategoria.Text = "Categoria";
            campoPreco.CasasDecimais = 2;
            campoPreco.ForeColor = Color.White;
            campoPreco.Location = new Point(3, 117);
            campoPreco.Name = "campoPreco";
            campoPreco.Size = new Size(290, 51);
            campoPreco.TabIndex = 2;
            campoPreco.TabStop = false;
            campoPreco.Text = "Preço (R$)";
            campoEstoque.ForeColor = Color.White;
            campoEstoque.Location = new Point(3, 174);
            campoEstoque.Name = "campoEstoque";
            campoEstoque.Size = new Size(290, 51);
            campoEstoque.TabIndex = 3;
            campoEstoque.TabStop = false;
            campoEstoque.Text = "Estoque";
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 60);
            panel1.TabIndex = 1;
            btnSalvar.Location = new Point(88, 16);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 28);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(296, 292);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += frmCadastroProduto_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Componentes.CampoTexto campoNome;
        private Componentes.CampoLista campoCategoria;
        private Componentes.CampoNumero campoPreco;
        private Componentes.CampoNumero campoEstoque;
        private Panel panel1;
        private Componentes.Botao btnSalvar;
    }
}
