namespace TrabalhoBan.Telas.Auxiliares
{
    partial class frmComprarComputador
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
            panel1 = new Panel();
            button1 = new Button();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            txtProcessador = new TextBox();
            groupBox4 = new GroupBox();
            txtPlacaDeVideo = new TextBox();
            groupBox6 = new GroupBox();
            comboRam = new ComboBox();
            groupBox9 = new GroupBox();
            nmValorHora = new NumericUpDown();
            groupBox7 = new GroupBox();
            numValorCorujao = new NumericUpDown();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox8 = new GroupBox();
            dateCompra = new DateTimePicker();
            groupBox11 = new GroupBox();
            numValor = new NumericUpDown();
            groupBox10 = new GroupBox();
            txtFornecedor = new TextBox();
            groupBox12 = new GroupBox();
            txtNota = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmValorHora).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValorCorujao).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            groupBox10.SuspendLayout();
            groupBox12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 295);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 45);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(831, 6);
            button1.Name = "button1";
            button1.Size = new Size(140, 32);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(977, 295);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 0, 64);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Computador";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(groupBox9);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(494, 273);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtProcessador);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(488, 47);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Processador";
            // 
            // txtProcessador
            // 
            txtProcessador.Location = new Point(6, 18);
            txtProcessador.Name = "txtProcessador";
            txtProcessador.Size = new Size(476, 23);
            txtProcessador.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtPlacaDeVideo);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 56);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(488, 47);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Placa de Video";
            // 
            // txtPlacaDeVideo
            // 
            txtPlacaDeVideo.Location = new Point(6, 18);
            txtPlacaDeVideo.Name = "txtPlacaDeVideo";
            txtPlacaDeVideo.Size = new Size(476, 23);
            txtPlacaDeVideo.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(comboRam);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(3, 109);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(488, 47);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Memoria Ram";
            // 
            // comboRam
            // 
            comboRam.FormattingEnabled = true;
            comboRam.Items.AddRange(new object[] { "1", "2", "4", "8", "16", "32", "64", "128" });
            comboRam.Location = new Point(6, 18);
            comboRam.Name = "comboRam";
            comboRam.Size = new Size(476, 23);
            comboRam.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(nmValorHora);
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(3, 162);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(488, 47);
            groupBox9.TabIndex = 3;
            groupBox9.TabStop = false;
            groupBox9.Text = "Valor Hora";
            // 
            // nmValorHora
            // 
            nmValorHora.Location = new Point(6, 18);
            nmValorHora.Name = "nmValorHora";
            nmValorHora.Size = new Size(476, 23);
            nmValorHora.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(numValorCorujao);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(3, 215);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(488, 47);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Valor Corujão";
            // 
            // numValorCorujao
            // 
            numValorCorujao.Location = new Point(6, 18);
            numValorCorujao.Name = "numValorCorujao";
            numValorCorujao.Size = new Size(476, 23);
            numValorCorujao.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(0, 0, 64);
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 295);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Compra";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(groupBox8);
            flowLayoutPanel2.Controls.Add(groupBox11);
            flowLayoutPanel2.Controls.Add(groupBox10);
            flowLayoutPanel2.Controls.Add(groupBox12);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(467, 273);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(dateCompra);
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(3, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(461, 47);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "Data de compra";
            // 
            // dateCompra
            // 
            dateCompra.Location = new Point(6, 18);
            dateCompra.Name = "dateCompra";
            dateCompra.Size = new Size(449, 23);
            dateCompra.TabIndex = 0;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(numValor);
            groupBox11.ForeColor = Color.White;
            groupBox11.Location = new Point(3, 56);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(461, 47);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            groupBox11.Text = "Valor";
            // 
            // numValor
            // 
            numValor.Location = new Point(6, 18);
            numValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(449, 23);
            numValor.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(txtFornecedor);
            groupBox10.ForeColor = Color.White;
            groupBox10.Location = new Point(3, 109);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(461, 47);
            groupBox10.TabIndex = 2;
            groupBox10.TabStop = false;
            groupBox10.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(6, 18);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(449, 23);
            txtFornecedor.TabIndex = 0;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(txtNota);
            groupBox12.ForeColor = Color.White;
            groupBox12.Location = new Point(3, 162);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(461, 47);
            groupBox12.TabIndex = 3;
            groupBox12.TabStop = false;
            groupBox12.Text = "Nota Fiscal";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(6, 18);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(449, 23);
            txtNota.TabIndex = 0;
            // 
            // frmComprarComputador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 340);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "frmComprarComputador";
            Text = "Comprar Computador";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmValorHora).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numValorCorujao).EndInit();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox3;
        private TextBox txtProcessador;
        private GroupBox groupBox4;
        private TextBox txtPlacaDeVideo;
        private GroupBox groupBox6;
        private ComboBox comboRam;
        private GroupBox groupBox9;
        private NumericUpDown nmValorHora;
        private GroupBox groupBox7;
        private NumericUpDown numValorCorujao;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox8;
        private DateTimePicker dateCompra;
        private GroupBox groupBox11;
        private NumericUpDown numValor;
        private GroupBox groupBox10;
        private TextBox txtFornecedor;
        private GroupBox groupBox12;
        private TextBox txtNota;
    }
}