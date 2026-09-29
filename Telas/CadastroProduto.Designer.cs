namespace TrabalhoBan.Telas
{
    partial class CadastroProduto
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
            cabecalho1 = new Componentes.Cabecalho();
            ViewProdutos = new DataGrid();
            ((System.ComponentModel.ISupportInitialize)ViewProdutos).BeginInit();
            SuspendLayout();
            cabecalho1.BackColor = Color.Navy;
            cabecalho1.Dica = "Double Click no produto para editar. Estoque abaixo de 5 fica vermelho.";
            cabecalho1.Dock = DockStyle.Top;
            cabecalho1.Location = new Point(0, 0);
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1428, 115);
            cabecalho1.TabIndex = 0;
            cabecalho1.Titulo = "Produtos";
            cabecalho1.Pesquisar += cabecalho1_Pesquisar;
            ViewProdutos.Dock = DockStyle.Fill;
            ViewProdutos.Location = new Point(0, 115);
            ViewProdutos.Name = "ViewProdutos";
            ViewProdutos.PermitirEditar = false;
            ViewProdutos.Size = new Size(1428, 642);
            ViewProdutos.TabIndex = 1;
            ViewProdutos.CellDoubleClick += ViewProdutos_CellDoubleClick;
            ViewProdutos.CellFormatting += ViewProdutos_CellFormatting;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewProdutos);
            Controls.Add(cabecalho1);
            Name = "CadastroProduto";
            Size = new Size(1428, 757);
            Load += CadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)ViewProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Componentes.Cabecalho cabecalho1;
        private DataGrid ViewProdutos;
    }
}
