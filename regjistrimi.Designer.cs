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
            Emri = new TextBox();
            RegjistrohuR = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pinR = new TextBox();
            ibanR = new TextBox();
            CVC = new TextBox();
            Mbiemri = new TextBox();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // Emri
            // 
            Emri.Location = new Point(119, 62);
            Emri.Margin = new Padding(3, 2, 3, 2);
            Emri.Multiline = true;
            Emri.Name = "Emri";
            Emri.Size = new Size(200, 38);
            Emri.TabIndex = 0;
            // 
            // RegjistrohuR
            // 
            RegjistrohuR.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegjistrohuR.Location = new Point(395, 228);
            RegjistrohuR.Margin = new Padding(3, 2, 3, 2);
            RegjistrohuR.Name = "RegjistrohuR";
            RegjistrohuR.Size = new Size(122, 40);
            RegjistrohuR.TabIndex = 4;
            RegjistrohuR.Text = "Regjistrohu";
            RegjistrohuR.UseVisualStyleBackColor = true;
            RegjistrohuR.Click += RegjistrohuR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 5;
            label1.Text = "Emri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 6;
            label2.Text = "IBAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(389, 123);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 7;
            label3.Text = "PIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(114, 202);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 9;
            label4.Text = "CVC";
            // 
            // pinR
            // 
            pinR.Location = new Point(395, 148);
            pinR.Margin = new Padding(3, 2, 3, 2);
            pinR.Multiline = true;
            pinR.Name = "pinR";
            pinR.Size = new Size(200, 38);
            pinR.TabIndex = 10;
            // 
            // ibanR
            // 
            ibanR.Location = new Point(119, 148);
            ibanR.Margin = new Padding(3, 2, 3, 2);
            ibanR.Multiline = true;
            ibanR.Name = "ibanR";
            ibanR.Size = new Size(200, 38);
            ibanR.TabIndex = 11;
            // 
            // CVC
            // 
            CVC.Location = new Point(119, 228);
            CVC.Margin = new Padding(3, 2, 3, 2);
            CVC.Multiline = true;
            CVC.Name = "CVC";
            CVC.Size = new Size(200, 38);
            CVC.TabIndex = 12;
            // 
            // Mbiemri
            // 
            Mbiemri.Location = new Point(395, 62);
            Mbiemri.Margin = new Padding(3, 2, 3, 2);
            Mbiemri.Multiline = true;
            Mbiemri.Name = "Mbiemri";
            Mbiemri.Size = new Size(200, 38);
            Mbiemri.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(389, 37);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 14;
            label5.Text = "Mbiemri";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14F);
            linkLabel1.Location = new Point(529, 236);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(51, 25);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kyçu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // regjistrimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(Mbiemri);
            Controls.Add(CVC);
            Controls.Add(ibanR);
            Controls.Add(pinR);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegjistrohuR);
            Controls.Add(Emri);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "regjistrimi";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Emri;
        private Button RegjistrohuR;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox pinR;
        private TextBox ibanR;
        private TextBox CVC;
        private TextBox Mbiemri;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}