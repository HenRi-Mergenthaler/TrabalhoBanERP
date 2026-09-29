namespace TrabalhoBan.Telas
{
    partial class Sessoes
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
            components = new System.ComponentModel.Container();
            cabecalho1 = new Componentes.Cabecalho();
            splitContainer1 = new SplitContainer();
            ViewSessoes = new DataGrid();
            ViewConsumo = new DataGrid();
            panel1 = new Panel();
            btnRemoverConsumo = new Componentes.Botao();
            lblConsumo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewSessoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewConsumo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            cabecalho1.BackColor = Color.Navy;
            cabecalho1.Dica = "Pesquise pelo nome do cliente ou numero do computador. Selecione a sessão pra ver o consumo.";
            cabecalho1.Dock = DockStyle.Top;
            cabecalho1.Location = new Point(0, 0);
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1428, 115);
            cabecalho1.TabIndex = 0;
            cabecalho1.Titulo = "Sessões em Andamento";
            cabecalho1.Pesquisar += cabecalho1_Pesquisar;
            splitContainer1.BackColor = Color.FromArgb(0, 0, 64);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 115);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Panel1.Controls.Add(ViewSessoes);
            splitContainer1.Panel2.Controls.Add(ViewConsumo);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1428, 642);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.TabIndex = 1;
            ViewSessoes.Dock = DockStyle.Fill;
            ViewSessoes.Location = new Point(0, 0);
            ViewSessoes.Name = "ViewSessoes";
            ViewSessoes.PermitirEditar = false;
            ViewSessoes.Size = new Size(1428, 380);
            ViewSessoes.TabIndex = 0;
            ViewSessoes.CellFormatting += ViewSessoes_CellFormatting;
            ViewSessoes.SelectionChanged += ViewSessoes_SelectionChanged;
            ViewConsumo.Dock = DockStyle.Fill;
            ViewConsumo.Location = new Point(0, 40);
            ViewConsumo.Name = "ViewConsumo";
            ViewConsumo.PermitirEditar = false;
            ViewConsumo.Size = new Size(1428, 218);
            ViewConsumo.TabIndex = 1;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnRemoverConsumo);
            panel1.Controls.Add(lblConsumo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 40);
            panel1.TabIndex = 0;
            btnRemoverConsumo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoverConsumo.Location = new Point(1288, 8);
            btnRemoverConsumo.Name = "btnRemoverConsumo";
            btnRemoverConsumo.Size = new Size(130, 23);
            btnRemoverConsumo.TabIndex = 1;
            btnRemoverConsumo.Text = "Remover Item";
            btnRemoverConsumo.Click += btnRemoverConsumo_Click;
            lblConsumo.AutoSize = true;
            lblConsumo.Font = new Font("Segoe UI", 12F);
            lblConsumo.ForeColor = Color.White;
            lblConsumo.Location = new Point(8, 9);
            lblConsumo.Name = "lblConsumo";
            lblConsumo.Size = new Size(147, 21);
            lblConsumo.TabIndex = 0;
            lblConsumo.Text = "Consumo da sessão";
            timer1.Interval = 30000;
            timer1.Tick += timer1_Tick;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(cabecalho1);
            Name = "Sessoes";
            Size = new Size(1428, 757);
            Load += Sessoes_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewSessoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewConsumo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Componentes.Cabecalho cabecalho1;
        private SplitContainer splitContainer1;
        private DataGrid ViewSessoes;
        private DataGrid ViewConsumo;
        private Panel panel1;
        private Componentes.Botao btnRemoverConsumo;
        private Label lblConsumo;
        private System.Windows.Forms.Timer timer1;
    }
}
