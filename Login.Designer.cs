namespace TrabalhoBan
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            pictureBox1.Image = Properties.Resources._25559747_7053246_1;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(52, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            textBox1.BackColor = Color.BlueViolet;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(42, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 1;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 145);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 202);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            textBox2.BackColor = Color.BlueViolet;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(42, 220);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 3;
            button1.BackColor = Color.BlueViolet;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(79, 259);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AcceptButton = button1;
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(252, 317);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LanHouse M - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}