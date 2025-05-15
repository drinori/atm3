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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë ngarkimit: {ex.Message}");
            }
        }

        private void RequestsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if it's the Veprim column but not the header
            if (e.ColumnIndex == requestsDataGridView.Columns["colVeprim"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                // Define button rectangles (left half for Approve, right half for Decline)
                Rectangle approveRect = new Rectangle(
                    e.CellBounds.X + 5,
                    e.CellBounds.Y + 5,
                    (e.CellBounds.Width / 2) - 10,
                    e.CellBounds.Height - 10);

                Rectangle declineRect = new Rectangle(
                    e.CellBounds.X + (e.CellBounds.Width / 2) + 5,
                    e.CellBounds.Y + 5,
                    (e.CellBounds.Width / 2) - 10,
                    e.CellBounds.Height - 10);

                // Check if the status is PENDING to determine if buttons should be active
                string status = e.RowIndex >= 0 && requestsDataGridView.Rows[e.RowIndex].Cells["colStatusi"].Value != null
                    ? requestsDataGridView.Rows[e.RowIndex].Cells["colStatusi"].Value.ToString()
                    : "";

                bool isActive = status == "PENDING";

                // Draw Approve button (green)
                using (var approveButtonBrush = new SolidBrush(isActive ? Color.FromArgb(76, 175, 80) : Color.FromArgb(200, 200, 200)))
                using (var buttonTextBrush = new SolidBrush(Color.White))
                using (var buttonFont = new Font("Segoe UI", 9))
                {
                    e.Graphics.FillRectangle(approveButtonBrush, approveRect);

                    // Center the text
                    SizeF textSize = e.Graphics.MeasureString("Aprovo", buttonFont);
                    PointF textPos = new PointF(
                        approveRect.X + (approveRect.Width - textSize.Width) / 2,
                        approveRect.Y + (approveRect.Height - textSize.Height) / 2);

                    e.Graphics.DrawString("Aprovo", buttonFont, buttonTextBrush, textPos);
                }

                // Draw Decline button (red)
                using (var declineButtonBrush = new SolidBrush(isActive ? Color.FromArgb(244, 67, 54) : Color.FromArgb(200, 200, 200)))
                using (var buttonTextBrush = new SolidBrush(Color.White))
                using (var buttonFont = new Font("Segoe UI", 9))
                {
                    e.Graphics.FillRectangle(declineButtonBrush, declineRect);

                    // Center the text
                    SizeF textSize = e.Graphics.MeasureString("Refuzo", buttonFont);
                    PointF textPos = new PointF(
                        declineRect.X + (declineRect.Width - textSize.Width) / 2,
                        declineRect.Y + (declineRect.Height - textSize.Height) / 2);

                    e.Graphics.DrawString("Refuzo", buttonFont, buttonTextBrush, textPos);
                }

                e.Handled = true;
            }
        }

        private void RequestsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if it's the Veprim column and not the header row
            if (e.ColumnIndex == requestsDataGridView.Columns["colVeprim"].Index && e.RowIndex >= 0)
            {
                // Get the status to check if it's PENDING
                string status = requestsDataGridView.Rows[e.RowIndex].Cells["colStatusi"].Value?.ToString() ?? "";

                if (status != "PENDING")
                {
                    MessageBox.Show("Mund të veproni vetëm në kërkesa të papërgjigjura!", "Kujdes");
                    return;
                }

                // Get the cell boundaries
                Rectangle cellBounds = requestsDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                // Get the mouse position relative to the cell
                Point relativePoint = requestsDataGridView.PointToClient(Cursor.Position);
                relativePoint = new Point(relativePoint.X - cellBounds.X, relativePoint.Y - cellBounds.Y);

                // Get the request ID
                int requestId = Convert.ToInt32(requestsDataGridView.Rows[e.RowIndex].Cells["colId"].Value);

                // Check if click was in left or right half of the cell
                if (relativePoint.X < cellBounds.Width / 2)
                {
                    // Approve button clicked
                    if (MessageBox.Show("Aprovo kërkesën?", "Konfirmim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ApproveRequest(requestId);
                    }
                }
                else
                {
                    // Decline button clicked
                    if (MessageBox.Show("Refuzo kërkesën?", "Konfirmim", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

                                decimal balance = GetAccountBalance(currentUserIban, connection, transaction);
                                if (balance < amount)
                                {
                                    throw new Exception("Nuk keni fonde të mjaftueshme!");
                                }

                                TransferMoney(currentUserIban, requesterIban, amount, connection, transaction);
                                UpdateRequestStatus(requestId, "APPROVED", connection, transaction);

                                transaction.Commit();
                                MessageBox.Show("Kërkesa u aprovua me sukses!");
                                LoadRequests();
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
                        MessageBox.Show("Kërkesa u refuzua!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRequests();
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
            string deductQuery = "UPDATE perdoruesit SET bilanci = bilanci - @amount WHERE iban = @iban";
            SqlCommand deductCmd = new SqlCommand(deductQuery, connection, transaction);
            deductCmd.Parameters.AddWithValue("@amount", amount);
            deductCmd.Parameters.AddWithValue("@iban", fromIban);
            deductCmd.ExecuteNonQuery();

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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (this.Owner != null && this.Owner is menu)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                menu menuForm = new menu("User", "");
                menuForm.Show();
                this.Close();
            }
        }
    }
}