namespace atm
{
    partial class regjistrimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regjistrimi));
            Emri = new TextBox();
            RegjistrohuR = new Button();
            pinR = new TextBox();
            ibanR = new TextBox();
            CVC = new TextBox();
            Mbiemri = new TextBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Emri
            // 
            Emri.Font = new Font("Segoe UI", 14F);
            Emri.Location = new Point(130, 159);
            Emri.Name = "Emri";
            Emri.PlaceholderText = "Emri";
            Emri.Size = new Size(332, 39);
            Emri.TabIndex = 0;
            // 
            // RegjistrohuR
            // 
            RegjistrohuR.Font = new Font("Segoe UI", 14F);
            RegjistrohuR.Location = new Point(667, 374);
            RegjistrohuR.Name = "RegjistrohuR";
            RegjistrohuR.Size = new Size(159, 53);
            RegjistrohuR.TabIndex = 4;
            RegjistrohuR.Text = "Regjistrohu";
            RegjistrohuR.UseVisualStyleBackColor = true;
            RegjistrohuR.Click += RegjistrohuR_Click;
            // 
            // pinR
            // 
            pinR.Font = new Font("Segoe UI", 14F);
            pinR.Location = new Point(634, 257);
            pinR.Name = "pinR";
            pinR.PlaceholderText = "PIN";
            pinR.Size = new Size(333, 39);
            pinR.TabIndex = 10;
            // 
            // ibanR
            // 
            ibanR.Font = new Font("Segoe UI", 14F);
            ibanR.Location = new Point(130, 257);
            ibanR.Name = "ibanR";
            ibanR.PlaceholderText = "IBAN";
            ibanR.Size = new Size(332, 39);
            ibanR.TabIndex = 11;
            // 
            // CVC
            // 
            CVC.Font = new Font("Segoe UI", 14F);
            CVC.Location = new Point(130, 382);
            CVC.Name = "CVC";
            CVC.PlaceholderText = "CVC";
            CVC.Size = new Size(332, 39);
            CVC.TabIndex = 12;
            // 
            // Mbiemri
            // 
            Mbiemri.Font = new Font("Segoe UI", 14F);
            Mbiemri.Location = new Point(634, 159);
            Mbiemri.Name = "Mbiemri";
            Mbiemri.PlaceholderText = "Mbiemri";
            Mbiemri.Size = new Size(333, 39);
            Mbiemri.TabIndex = 13;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.Location = new Point(859, 392);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(67, 35);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kyçu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ibanR);
            panel1.Controls.Add(CVC);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(Mbiemri);
            panel1.Controls.Add(RegjistrohuR);
            panel1.Controls.Add(pinR);
            panel1.Controls.Add(Emri);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 576);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(944, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 116);
            panel2.TabIndex = 16;
            // 
            // regjistrimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 576);
            Controls.Add(panel1);
            Name = "regjistrimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Emri;
        private Button RegjistrohuR;
        private TextBox pinR;
        private TextBox ibanR;
        private TextBox CVC;
        private TextBox Mbiemri;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel panel2;
    }
}