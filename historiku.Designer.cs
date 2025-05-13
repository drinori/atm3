using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace atm
{
    partial class historiku
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiku));
            transactionsDataGridView = new DataGridView();
            returnButton = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.AllowUserToAddRows = false;
            transactionsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            transactionsDataGridView.BackgroundColor = Color.FromArgb(217, 217, 217);
            transactionsDataGridView.BorderStyle = BorderStyle.None;
            transactionsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            transactionsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(222, 7, 20);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(222, 7, 20);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            transactionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            transactionsDataGridView.ColumnHeadersHeight = 40;
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            transactionsDataGridView.EnableHeadersVisualStyles = false;
            transactionsDataGridView.GridColor = Color.FromArgb(230, 230, 230);
            transactionsDataGridView.Location = new Point(23, 107);
            transactionsDataGridView.Margin = new Padding(3, 4, 3, 4);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.ReadOnly = true;
            transactionsDataGridView.RowHeadersVisible = false;
            transactionsDataGridView.RowHeadersWidth = 51;
            transactionsDataGridView.RowTemplate.Height = 35;
            transactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionsDataGridView.Size = new Size(1070, 325);
            transactionsDataGridView.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.White;
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.ForeColor = Color.Black;
            returnButton.Location = new Point(910, 440);
            returnButton.Margin = new Padding(3, 4, 3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(183, 53);
            returnButton.TabIndex = 1;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += ReturnButton_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.LightGray;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(23, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1070, 53);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Historia e Transaksioneve";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(transactionsDataGridView);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(23, 27, 23, 27);
            panel1.Size = new Size(1111, 504);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(returnButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 504);
            panel2.TabIndex = 3;
            // 
            // historiku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 247);
            ClientSize = new Size(1111, 504);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "historiku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historia e Transaksioneve";
            Load += TransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private DataGridView transactionsDataGridView;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
    }
}