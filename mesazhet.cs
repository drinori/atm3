using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace atm
{
    public partial class mesazhet : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";
        string currentUserIban;

        public mesazhet(string userIban)
        {
            InitializeComponent();
            currentUserIban = userIban;
            this.Load += Mesazhet_Load;
            btnRefresh.Click += BtnRefresh_Click;
            btnReturn.Click += BtnReturn_Click;

            // Set up the custom button rendering and click handling for Veprim column
            requestsDataGridView.CellPainting += RequestsDataGridView_CellPainting;
            requestsDataGridView.CellClick += RequestsDataGridView_CellClick;
        }

        private void Mesazhet_Load(object sender, EventArgs e)
        {
            // Add the action column if it doesn't exist
            if (!requestsDataGridView.Columns.Contains("colVeprim"))
            {
                DataGridViewColumn actionColumn = new DataGridViewColumn();
                actionColumn.Name = "colVeprim";
                actionColumn.HeaderText = "Veprim";
                actionColumn.CellTemplate = new DataGridViewTextBoxCell();
                requestsDataGridView.Columns.Add(actionColumn);
            }

            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                            k.Id,
                            k.iban AS 'Nga',
                            k.shuma AS 'Shuma',
                            k.mesazhi AS 'Mesazhi',
                            FORMAT(k.data_kerkeses, 'dd/MM/yyyy HH:mm') AS 'Data',
                            k.statusi AS 'Statusi'
                            FROM kerkesat_para k
                            WHERE k.iban_marresit = @UserIban
                            ORDER BY k.data_kerkeses DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserIban", currentUserIban);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    requestsDataGridView.DataSource = dataTable;

                    // Make sure the columns exist in the DataGridView
                    if (requestsDataGridView.Columns.Contains("Id"))
                        requestsDataGridView.Columns["Id"].Visible = false;

                    if (requestsDataGridView.Columns.Contains("Statusi"))
                        requestsDataGridView.Columns["Statusi"].HeaderText = "Statusi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë ngarkimit: {ex.Message}");
            }
        }

        private void RequestsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Only paint the action column and not the header
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                requestsDataGridView.Columns[e.ColumnIndex].Name == "colVeprim")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                // Get the status value
                string status = "";
                if (requestsDataGridView.Columns.Contains("Statusi") &&
                    requestsDataGridView.Rows[e.RowIndex].Cells["Statusi"].Value != null)
                {
                    status = requestsDataGridView.Rows[e.RowIndex].Cells["Statusi"].Value.ToString();
                }

                bool isActive = status == "PENDING";

                // Define button rectangles (left half for Approve, right half for Decline)
                Rectangle approveRect = new Rectangle(
                    e.CellBounds.X + 2,
                    e.CellBounds.Y + 2,
                    (e.CellBounds.Width / 2) - 4,
                    e.CellBounds.Height - 4);

                Rectangle declineRect = new Rectangle(
                    e.CellBounds.X + (e.CellBounds.Width / 2) + 2,
                    e.CellBounds.Y + 2,
                    (e.CellBounds.Width / 2) - 4,
                    e.CellBounds.Height - 4);

                // Draw Approve button (green if active, gray if not)
                using (var approveButtonBrush = new SolidBrush(isActive ? Color.FromArgb(76, 175, 80) : Color.LightGray))
                using (var buttonTextBrush = new SolidBrush(isActive ? Color.White : Color.DarkGray))
                using (var buttonFont = new Font("Segoe UI", 8, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(approveButtonBrush, approveRect);
                    e.Graphics.DrawRectangle(Pens.DarkGray, approveRect);

                    // Center the text
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    e.Graphics.DrawString("Aprovo", buttonFont, buttonTextBrush, approveRect, sf);
                }

                // Draw Decline button (red if active, gray if not)
                using (var declineButtonBrush = new SolidBrush(isActive ? Color.FromArgb(244, 67, 54) : Color.LightGray))
                using (var buttonTextBrush = new SolidBrush(isActive ? Color.White : Color.DarkGray))
                using (var buttonFont = new Font("Segoe UI", 8, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(declineButtonBrush, declineRect);
                    e.Graphics.DrawRectangle(Pens.DarkGray, declineRect);

                    // Center the text
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    e.Graphics.DrawString("Refuzo", buttonFont, buttonTextBrush, declineRect, sf);
                }

                e.Handled = true;
            }
        }

        private void RequestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle clicks on the action column and not the header
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                requestsDataGridView.Columns[e.ColumnIndex].Name == "colVeprim")
            {
                // Get the status value
                string status = "";
                if (requestsDataGridView.Columns.Contains("Statusi") &&
                    requestsDataGridView.Rows[e.RowIndex].Cells["Statusi"].Value != null)
                {
                    status = requestsDataGridView.Rows[e.RowIndex].Cells["Statusi"].Value.ToString();
                }

                // Only allow actions if status is PENDING
                if (status != "PENDING")
                {
                    MessageBox.Show("Mund të veproni vetëm në kërkesa me status PENDING");
                    return;
                }

                // Get the request ID
                int requestId = Convert.ToInt32(requestsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                // Get the click position relative to the cell
                DataGridViewCell cell = requestsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle cellRect = requestsDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point clickPosition = requestsDataGridView.PointToClient(Cursor.Position);
                int xRelative = clickPosition.X - cellRect.X;

                // Check which button was clicked
                if (xRelative < cellRect.Width / 2)
                {
                    // Approve button clicked
                    if (MessageBox.Show("A jeni i sigurtë që dëshironi të aprovoni këtë kërkesë?", "Konfirmim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ApproveRequest(requestId);
                    }
                }
                else
                {
                    // Decline button clicked
                    if (MessageBox.Show("A jeni i sigurtë që dëshironi të refuzoni këtë kërkesë?", "Konfirmim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeclineRequest(requestId);
                    }
                }
            }
        }

        private void ApproveRequest(int requestId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // 1. Get request details
                        string getQuery = @"SELECT iban, shuma 
                                          FROM kerkesat_para 
                                          WHERE Id = @Id AND statusi = 'PENDING'";
                        SqlCommand getCmd = new SqlCommand(getQuery, connection, transaction);
                        getCmd.Parameters.AddWithValue("@Id", requestId);

                        using (SqlDataReader reader = getCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string requesterIban = reader["iban"].ToString();
                                decimal amount = Convert.ToDecimal(reader["shuma"]);
                                reader.Close();

                                // 2. Check if current user has enough balance
                                decimal balance = GetAccountBalance(currentUserIban, connection, transaction);
                                if (balance < amount)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Fonde të pamjaftueshme! Ju nuk mund ta aprovoni këtë kërkesë.");
                                    return;
                                }

                                // 3. Transfer money
                                TransferMoney(currentUserIban, requesterIban, amount, connection, transaction);

                                // 4. Update request status
                                UpdateRequestStatus(requestId, "APPROVED", connection, transaction);

                                // 5. Create transaction record
                                CreateTransactionRecord(currentUserIban, requesterIban, amount, "TRANSFER", connection, transaction);

                                transaction.Commit();
                                MessageBox.Show("Kërkesa u aprovua me sukses!");
                                LoadRequests();
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Kërkesa nuk u gjet ose është përpunuar tashmë.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Gabim gjatë aprovimit: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeclineRequest(int requestId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE kerkesat_para 
                                   SET statusi = 'REJECTED' 
                                   WHERE Id = @Id AND statusi = 'PENDING'";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", requestId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kërkesa u refuzua me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRequests();
                    }
                    else
                    {
                        MessageBox.Show("Kërkesa nuk u gjet ose është përpunuar tashmë.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë refuzimit: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetAccountBalance(string iban, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "SELECT bilanci FROM perdoruesit WHERE iban = @iban";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@iban", iban);
            return Convert.ToDecimal(command.ExecuteScalar());
        }

        private void TransferMoney(string fromIban, string toIban, decimal amount, SqlConnection connection, SqlTransaction transaction)
        {
            // Deduct from sender
            string deductQuery = "UPDATE perdoruesit SET bilanci = bilanci - @amount WHERE iban = @iban";
            SqlCommand deductCmd = new SqlCommand(deductQuery, connection, transaction);
            deductCmd.Parameters.AddWithValue("@amount", amount);
            deductCmd.Parameters.AddWithValue("@iban", fromIban);
            deductCmd.ExecuteNonQuery();

            // Add to receiver
            string addQuery = "UPDATE perdoruesit SET bilanci = bilanci + @amount WHERE iban = @iban";
            SqlCommand addCmd = new SqlCommand(addQuery, connection, transaction);
            addCmd.Parameters.AddWithValue("@amount", amount);
            addCmd.Parameters.AddWithValue("@iban", toIban);
            addCmd.ExecuteNonQuery();
        }

        private void UpdateRequestStatus(int requestId, string status, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE kerkesat_para SET statusi = @status WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@Id", requestId);
            command.ExecuteNonQuery();
        }

        private void CreateTransactionRecord(string fromIban, string toIban, decimal amount, string type,
                                           SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"INSERT INTO transaksionet (iban, tipi, iban_marresit, shuma, Tdata, perdoruesiID)
                           VALUES (@iban, @tipi, @ibanMarresi, @shuma, @tdata, 
                                   (SELECT Id FROM perdoruesit WHERE iban = @iban))";

            SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@iban", fromIban);
            command.Parameters.AddWithValue("@tipi", type);
            command.Parameters.AddWithValue("@ibanMarresi", toIban);
            command.Parameters.AddWithValue("@shuma", amount);
            command.Parameters.AddWithValue("@tdata", DateTime.Now);

            command.ExecuteNonQuery();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }
    }
}