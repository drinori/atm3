namespace atm
{
    partial class dergo
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
            send = new Button();
            kthehu = new Button();
            messagebox = new TextBox();
            marresiIBAN = new TextBox();
            shuma = new TextBox();
            SuspendLayout();
            // 
            // send
            // 
            send.Location = new Point(593, 359);
            send.Name = "send";
            send.Size = new Size(158, 49);
            send.TabIndex = 0;
            send.Text = "Dërgo";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // kthehu
            // 
            kthehu.Location = new Point(117, 359);
            kthehu.Name = "kthehu";
            kthehu.Size = new Size(158, 49);
            kthehu.TabIndex = 1;
            kthehu.Text = "Kthehu";
            kthehu.UseVisualStyleBackColor = true;
            kthehu.Click += kthehu_Click;
            // 
            // messagebox
            // 
            messagebox.Location = new Point(504, 131);
            messagebox.Multiline = true;
            messagebox.Name = "messagebox";
            messagebox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messagebox.Size = new Size(247, 180);
            messagebox.TabIndex = 2;
            // 
            // marresiIBAN
            // 
            marresiIBAN.Location = new Point(117, 128);
            marresiIBAN.Multiline = true;
            marresiIBAN.Name = "marresiIBAN";
            marresiIBAN.PlaceholderText = "IBAN i marrësit";
            marresiIBAN.Size = new Size(238, 41);
            marresiIBAN.TabIndex = 3;
            // 
            // shuma
            // 
            shuma.Location = new Point(117, 270);
            shuma.Multiline = true;
            shuma.Name = "shuma";
            shuma.PlaceholderText = "Shuma e kërkuar";
            shuma.Size = new Size(238, 41);
            shuma.TabIndex = 4;
            // 
            // dergo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shuma);
            Controls.Add(marresiIBAN);
            Controls.Add(messagebox);
            Controls.Add(kthehu);
            Controls.Add(send);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dergo";
            Text = "dergo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button send;
        private Button kthehu;
        private TextBox messagebox;
        private TextBox marresiIBAN;
        private TextBox shuma;
    }
}