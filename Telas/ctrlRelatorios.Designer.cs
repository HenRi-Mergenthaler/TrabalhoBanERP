namespace TrabalhoBan.Telas
{
    partial class ctrlRelatorios
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
            campoRelatorio = new Componentes.CampoLista();
            campoDe = new Componentes.CampoData();
            campoAte = new Componentes.CampoData();
            ViewRelatorio = new DataGrid();
            lblTotal = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewRelatorio).BeginInit();
            SuspendLayout();
            cabecalho1.BackColor = Color.Navy;
            cabecalho1.Dica = "";
            cabecalho1.Dock = DockStyle.Top;
            cabecalho1.Location = new Point(0, 0);
            cabecalho1.MostrarPesquisa = false;
            cabecalho1.Name = "cabecalho1";
            cabecalho1.Size = new Size(1428, 115);
            cabecalho1.TabIndex = 0;
            cabecalho1.Titulo = "Relatórios";
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 64);
            flowLayoutPanel1.Controls.Add(campoRelatorio);
            flowLayoutPanel1.Controls.Add(campoDe);
            flowLayoutPanel1.Controls.Add(campoAte);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 115);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 5);
            flowLayoutPanel1.Size = new Size(1428, 70);
            flowLayoutPanel1.TabIndex = 1;
            campoRelatorio.ForeColor = Color.White;
            campoRelatorio.Location = new Point(13, 8);
            campoRelatorio.Name = "campoRelatorio";
            campoRelatorio.Size = new Size(320, 51);
            campoRelatorio.TabIndex = 0;
            campoRelatorio.TabStop = false;
            campoRelatorio.Text = "Relatório";
            campoRelatorio.ItemSelecionado += campoRelatorio_ItemSelecionado;
            campoDe.ForeColor = Color.White;
            campoDe.Location = new Point(339, 8);
            campoDe.Name = "campoDe";
            campoDe.Size = new Size(200, 51);
            campoDe.TabIndex = 1;
            campoDe.TabStop = false;
            campoDe.Text = "De";
            campoAte.ForeColor = Color.White;
            campoAte.Location = new Point(545, 8);
            campoAte.Name = "campoAte";
            campoAte.Size = new Size(200, 51);
            campoAte.TabIndex = 2;
            campoAte.TabStop = false;
            campoAte.Text = "Até";
            ViewRelatorio.Dock = DockStyle.Fill;
            ViewRelatorio.Location = new Point(0, 185);
            ViewRelatorio.Name = "ViewRelatorio";
            ViewRelatorio.PermitirEditar = false;
            ViewRelatorio.Size = new Size(1428, 532);
            ViewRelatorio.TabIndex = 2;
            lblTotal.BackColor = Color.Navy;
            lblTotal.Dock = DockStyle.Bottom;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(0, 717);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(8, 0, 0, 0);
            lblTotal.Size = new Size(1428, 40);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: R$ 0,00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ViewRelatorio);
            Controls.Add(lblTotal);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cabecalho1);
            Name = "ctrlRelatorios";
            Size = new Size(1428, 757);
            Load += ctrlRelatorios_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewRelatorio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Componentes.Cabecalho cabecalho1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Componentes.CampoLista campoRelatorio;
        private Componentes.CampoData campoDe;
        private Componentes.CampoData campoAte;
        private DataGrid ViewRelatorio;
        private Label lblTotal;
    }
}
