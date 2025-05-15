using System.Windows.Forms;

namespace atm
{
    partial class kyqja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kyqja));
            Kyqu = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Kyqu
            // 
            Kyqu.Font = new Font("Segoe UI", 14F);
            Kyqu.Location = new Point(747, 381);
            Kyqu.Name = "Kyqu";
            Kyqu.Size = new Size(167, 49);
            Kyqu.TabIndex = 0;
            Kyqu.Text = "Kyçu";
            Kyqu.UseVisualStyleBackColor = true;
            Kyqu.Click += Kyqu_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(747, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "IBAN";
            textBox1.Size = new Size(282, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(747, 274);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "PIN";
            textBox2.Size = new Size(282, 47);
            textBox2.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(920, 402);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Regjistrohu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(706, 278);
            panel3.Name = "panel3";
            panel3.Size = new Size(42, 35);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(704, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(42, 35);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(704, 421);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // kyqja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1111, 576);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            Controls.Add(Kyqu);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Name = "kyqja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kyqja";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Kyqu;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
    }
}