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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle centerCellStyle = new System.Windows.Forms.DataGridViewCellStyle(); // New style for centering

            transactionsDataGridView = new DataGridView();
            returnButton = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // transactionsDataGridView
            transactionsDataGridView.AllowUserToAddRows = false;
            transactionsDataGridView.AllowUserToDeleteRows = false;
            transactionsDataGridView.BackgroundColor = Color.White;
            transactionsDataGridView.BorderStyle = BorderStyle.None;
            transactionsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            transactionsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 130);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 70, 130);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            transactionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            transactionsDataGridView.ColumnHeadersHeight = 40;
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;

            // Create a centered cell style
            centerCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            centerCellStyle.BackColor = Color.White;
            centerCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            centerCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            centerCellStyle.Padding = new Padding(5);
            centerCellStyle.SelectionBackColor = Color.FromArgb(229, 243, 255);
            centerCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            centerCellStyle.WrapMode = DataGridViewTriState.False;

            transactionsDataGridView.EnableHeadersVisualStyles = false;
            transactionsDataGridView.GridColor = Color.FromArgb(230, 230, 230);
            transactionsDataGridView.Location = new Point(20, 80);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.ReadOnly = true;
            transactionsDataGridView.RowHeadersVisible = false;
            transactionsDataGridView.RowTemplate.Height = 35;
            transactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionsDataGridView.Size = new Size(760, 350);
            transactionsDataGridView.TabIndex = 0;

            // After initializing the DataGridView, you'll need to set the cell style for the "Shuma" column
            // This is typically done in the TransactionHistory_Load event or similar
            // But for demonstration, I'll show how to do it here:
            transactionsDataGridView.CellFormatting += (sender, e) =>
            {
                if (transactionsDataGridView.Columns[e.ColumnIndex].Name == "Shuma" && e.Value != null)
                {
                    e.CellStyle = centerCellStyle;
                    e.Value = string.Format("{0:N}", Convert.ToDecimal(e.Value)); // Optional: format as number
                }
            };

            // returnButton
            returnButton.BackColor = Color.FromArgb(0, 70, 130);
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(620, 450);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(160, 40);
            returnButton.TabIndex = 1;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += ReturnButton_Click;

            // lblTitle
            lblTitle.AutoSize = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 70, 130);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(760, 40);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Historia e Transaksioneve";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // panel1
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(transactionsDataGridView);
            panel1.Controls.Add(returnButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(800, 500);
            panel1.TabIndex = 3;

            // historiku
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 247);
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "historiku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historia e Transaksioneve";
            Load += TransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private DataGridView transactionsDataGridView;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel1;


    }
}