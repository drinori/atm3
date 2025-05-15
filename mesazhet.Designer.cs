namespace atm
{
    partial class mesazhet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            requestsDataGridView = new DataGridView();
            colVeprim = new DataGridViewButtonColumn();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelFooter = new Panel();
            btnRefresh = new Button();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).BeginInit();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // requestsDataGridView
            // 
            requestsDataGridView.AllowUserToAddRows = false;
            requestsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            requestsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            requestsDataGridView.BackgroundColor = Color.White;
            requestsDataGridView.BorderStyle = BorderStyle.None;
            requestsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            requestsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            requestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            requestsDataGridView.ColumnHeadersHeight = 40;
            requestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            requestsDataGridView.Columns.AddRange(new DataGridViewColumn[] { colVeprim });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(222, 8, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            requestsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            requestsDataGridView.EnableHeadersVisualStyles = false;
            requestsDataGridView.GridColor = Color.FromArgb(230, 230, 230);
            requestsDataGridView.Location = new Point(23, 107);
            requestsDataGridView.Margin = new Padding(3, 4, 3, 4);
            requestsDataGridView.Name = "requestsDataGridView";
            requestsDataGridView.ReadOnly = true;
            requestsDataGridView.RowHeadersVisible = false;
            requestsDataGridView.RowHeadersWidth = 51;
            requestsDataGridView.RowTemplate.Height = 35;
            requestsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            requestsDataGridView.Size = new Size(1229, 560);
            requestsDataGridView.TabIndex = 0;
            // 
            // colVeprim
            // 
            colVeprim.HeaderText = "Veprim";
            colVeprim.MinimumWidth = 6;
            colVeprim.Name = "colVeprim";
            colVeprim.ReadOnly = true;
            colVeprim.Width = 160;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 70, 130);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1290, 93);
            panelHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Mesazhet";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(240, 240, 240);
            panelFooter.Controls.Add(btnRefresh);
            panelFooter.Controls.Add(btnReturn);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 692);
            panelFooter.Margin = new Padding(3, 4, 3, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1290, 80);
            panelFooter.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 120, 215);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(743, 20);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 47);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Rifresko";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(200, 200, 200);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(57, 20);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(114, 47);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Kthehu";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // mesazhet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1290, 772);
            Controls.Add(requestsDataGridView);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mesazhet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesazhet";
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView requestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesazhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusi;
        private System.Windows.Forms.DataGridViewButtonColumn colVeprim;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReturn;
    }
}