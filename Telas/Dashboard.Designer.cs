namespace TrabalhoBan.Telas
{
    partial class Dashboard
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            cardLivres = new Componentes.CardInfo();
            cardSessoes = new Componentes.CardInfo();
            cardFaturamento = new Componentes.CardInfo();
            cardEstoque = new Componentes.CardInfo();
            label1 = new Label();
            ViewComputadores = new DataGrid();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewComputadores).BeginInit();
            SuspendLayout();
            cabecalho1.BackColor = Color.Navy;
            cabecalho1.Dica = "";
            cabecalho1.Dock = DockStyle.Top;
            cabecalho1.Location = new Point(0, 0);
            cabecalho1.MostrarPesquisa = false;
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1428, 115);
            cabecalho1.TabIndex = 0;
            cabecalho1.Titulo = "DashBoard";
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 64);
            flowLayoutPanel1.Controls.Add(cardLivres);
            flowLayoutPanel1.Controls.Add(cardSessoes);
            flowLayoutPanel1.Controls.Add(cardFaturamento);
            flowLayoutPanel1.Controls.Add(cardEstoque);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 115);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1428, 160);
            flowLayoutPanel1.TabIndex = 1;
            cardLivres.BackColor = Color.SeaGreen;
            cardLivres.Location = new Point(20, 20);
            cardLivres.Name = "cardLivres";
            cardLivres.Size = new Size(260, 120);
            cardLivres.TabIndex = 0;
            cardLivres.Titulo = "Computadores Livres";
            cardLivres.Valor = "-";
            cardSessoes.BackColor = Color.DarkOrange;
            cardSessoes.Location = new Point(300, 20);
            cardSessoes.Name = "cardSessoes";
            cardSessoes.Size = new Size(260, 120);
            cardSessoes.TabIndex = 1;
            cardSessoes.Titulo = "Sessões em Andamento";
            cardSessoes.Valor = "-";
            cardFaturamento.BackColor = Color.BlueViolet;
            cardFaturamento.Location = new Point(580, 20);
            cardFaturamento.Name = "cardFaturamento";
            cardFaturamento.Size = new Size(260, 120);
            cardFaturamento.TabIndex = 2;
            cardFaturamento.Titulo = "Faturamento de Hoje";
            cardFaturamento.Valor = "-";
            cardEstoque.BackColor = Color.DarkRed;
            cardEstoque.Location = new Point(860, 20);
            cardEstoque.Name = "cardEstoque";
            cardEstoque.Size = new Size(260, 120);
            cardEstoque.TabIndex = 3;
            cardEstoque.Titulo = "Produtos com Estoque Baixo";
            cardEstoque.Valor = "-";
            label1.BackColor = Color.Navy;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 275);
            label1.Name = "label1";
            label1.Padding = new Padding(8, 0, 0, 0);
            label1.Size = new Size(1428, 35);
            label1.TabIndex = 2;
            label1.Text = "Situação dos Computadores";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            ViewComputadores.Dock = DockStyle.Fill;
            ViewComputadores.Location = new Point(0, 310);
            ViewComputadores.Name = "ViewComputadores";
            ViewComputadores.PermitirEditar = false;
            ViewComputadores.Size = new Size(1428, 447);
            ViewComputadores.TabIndex = 3;
            ViewComputadores.CellFormatting += ViewComputadores_CellFormatting;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewComputadores);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cabecalho1);
            Name = "Dashboard";
            Size = new Size(1428, 757);
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewComputadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Componentes.Cabecalho cabecalho1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Componentes.CardInfo cardLivres;
        private Componentes.CardInfo cardSessoes;
        private Componentes.CardInfo cardFaturamento;
        private Componentes.CardInfo cardEstoque;
        private Label label1;
        private DataGrid ViewComputadores;
    }
}
