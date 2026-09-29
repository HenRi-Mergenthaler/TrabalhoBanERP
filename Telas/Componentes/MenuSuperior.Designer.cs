namespace TrabalhoBan.Telas.Componentes
{
    partial class MenuSuperior
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            botao1 = new Botao();
            comboBox1 = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(botao1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1000, 30);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // botao1
            // 
            botao1.Anchor = AnchorStyles.Left;
            botao1.BackColor = Color.BlueViolet;
            botao1.FlatAppearance.BorderSize = 0;
            botao1.FlatStyle = FlatStyle.Flat;
            botao1.ForeColor = Color.White;
            botao1.Location = new Point(3, 3);
            botao1.Name = "botao1";
            botao1.Size = new Size(130, 23);
            botao1.TabIndex = 0;
            botao1.Text = "botao1";
            botao1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 1;
            // 
            // MenuSuperior
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "MenuSuperior";
            Size = new Size(1000, 30);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Botao botao1;
        private ComboBox comboBox1;
    }
}
