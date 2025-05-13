namespace atm
{
    partial class terheqje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(terheqje));
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19F);
            textBox1.Location = new Point(396, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 50);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(124, 484);
            button1.Name = "button1";
            button1.Size = new Size(253, 68);
            button1.TabIndex = 1;
            button1.Text = "Kthehu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(786, 484);
            button3.Name = "button3";
            button3.Size = new Size(253, 68);
            button3.TabIndex = 3;
            button3.Text = "Vazhdo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // terheqje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Name = "terheqje";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
    }
}