namespace atm
{
    partial class dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            button1 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 143, 167);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 25, 41);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 112, 103);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 19F);
            button1.Location = new Point(580, 408);
            button1.Name = "button1";
            button1.Size = new Size(261, 77);
            button1.TabIndex = 0;
            button1.Text = "Regjistrohu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(127, 143, 167);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 25, 41);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 112, 103);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 19F);
            button3.Location = new Point(236, 408);
            button3.Name = "button3";
            button3.Size = new Size(261, 77);
            button3.TabIndex = 2;
            button3.Text = "Kyçu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1103, 405);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 5;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1102, 572);
            Controls.Add(button3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 24F);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}