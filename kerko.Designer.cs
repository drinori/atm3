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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kerko));
            panel2 = new Panel();
            panel1 = new Panel();
            lblTitle = new Label();
            recipientIbanTextBox = new TextBox();
            returnButton = new Button();
            amountTextBox = new TextBox();
            requestButton = new Button();
            messageTextBox = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 568);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(515, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 469);
            panel1.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.Location = new Point(87, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 37);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Kërko Para";
            // 
            // recipientIbanTextBox
            // 
            recipientIbanTextBox.Font = new Font("Segoe UI", 10F);
            recipientIbanTextBox.Location = new Point(87, 122);
            recipientIbanTextBox.Margin = new Padding(3, 4, 3, 4);
            recipientIbanTextBox.Name = "recipientIbanTextBox";
            recipientIbanTextBox.PlaceholderText = "IBAN i marrësit";
            recipientIbanTextBox.Size = new Size(385, 30);
            recipientIbanTextBox.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.FromArgb(108, 117, 125);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(87, 494);
            returnButton.Margin = new Padding(3, 4, 3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(171, 53);
            returnButton.TabIndex = 4;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Segoe UI", 10F);
            amountTextBox.Location = new Point(87, 195);
            amountTextBox.Margin = new Padding(3, 4, 3, 4);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PlaceholderText = "Shuma e kërkuar";
            amountTextBox.Size = new Size(385, 30);
            amountTextBox.TabIndex = 1;
            // 
            // requestButton
            // 
            requestButton.BackColor = Color.FromArgb(0, 123, 255);
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            requestButton.ForeColor = Color.White;
            requestButton.Location = new Point(301, 494);
            requestButton.Margin = new Padding(3, 4, 3, 4);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(171, 53);
            requestButton.TabIndex = 3;
            requestButton.Text = "Dërgo Kërkesën";
            requestButton.UseVisualStyleBackColor = false;
            // 
            // messageTextBox
            // 
            messageTextBox.Font = new Font("Segoe UI", 10F);
            messageTextBox.Location = new Point(87, 271);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messageTextBox.Size = new Size(385, 187);
            messageTextBox.TabIndex = 2;
            // 
            // kerko
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 568);
            Controls.Add(lblTitle);
            Controls.Add(recipientIbanTextBox);
            Controls.Add(messageTextBox);
            Controls.Add(returnButton);
            Controls.Add(amountTextBox);
            Controls.Add(requestButton);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "kerko";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kërko Para";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private TextBox recipientIbanTextBox;
        private TextBox amountTextBox;
        private Button requestButton;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel1;
    }
}