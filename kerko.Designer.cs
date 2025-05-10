namespace atm
{
    partial class kerko
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
            panel2 = new Panel();
            returnButton = new Button();
            requestButton = new Button();
            messageTextBox = new TextBox();
            amountTextBox = new TextBox();
            recipientIbanTextBox = new TextBox();
            lblTitle = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(377, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 450);
            panel2.TabIndex = 7;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(108, 117, 125);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(30, 368);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(150, 40);
            returnButton.TabIndex = 4;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            // 
            // requestButton
            // 
            requestButton.BackColor = Color.FromArgb(0, 123, 255);
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            requestButton.ForeColor = Color.White;
            requestButton.Location = new Point(217, 368);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(150, 40);
            requestButton.TabIndex = 3;
            requestButton.Text = "Dërgo Kërkesën";
            requestButton.UseVisualStyleBackColor = false;
            // 
            // messageTextBox
            // 
            messageTextBox.Font = new Font("Segoe UI", 10F);
            messageTextBox.Location = new Point(30, 201);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messageTextBox.Size = new Size(337, 141);
            messageTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Segoe UI", 10F);
            amountTextBox.Location = new Point(30, 144);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PlaceholderText = "Shuma e kërkuar";
            amountTextBox.Size = new Size(337, 25);
            amountTextBox.TabIndex = 1;
            // 
            // recipientIbanTextBox
            // 
            recipientIbanTextBox.Font = new Font("Segoe UI", 10F);
            recipientIbanTextBox.Location = new Point(30, 89);
            recipientIbanTextBox.Name = "recipientIbanTextBox";
            recipientIbanTextBox.PlaceholderText = "IBAN i marrësit";
            recipientIbanTextBox.Size = new Size(337, 25);
            recipientIbanTextBox.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.Location = new Point(30, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 30);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Kërko Para";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(recipientIbanTextBox);
            panel1.Controls.Add(amountTextBox);
            panel1.Controls.Add(messageTextBox);
            panel1.Controls.Add(requestButton);
            panel1.Controls.Add(returnButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 450);
            panel1.TabIndex = 6;
            // 
            // kerko
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kerko";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kërko Para";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox messageTextBox;
        private TextBox recipientIbanTextBox;
        private TextBox amountTextBox;
        private Button requestButton;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
    }
}