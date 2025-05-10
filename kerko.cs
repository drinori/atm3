using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace atm
{
    public partial class kerko : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";

        public kerko()
        {
            InitializeComponent();
            // Set button click handlers
            requestButton.Click += RequestButton_Click;
            returnButton.Click += ReturnButton_Click;

            // Add input validation
            amountTextBox.KeyPress += AmountTextBox_KeyPress;
        }
        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(recipientIbanTextBox.Text))
            {
                MessageBox.Show("Ju lutem shkruani IBAN-in e marrësit!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountTextBox.Text, out decimal shumaKerkuar) || shumaKerkuar <= 0)
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide dhe pozitive!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get current user's IBAN from owner form
            menu parentForm = this.Owner as menu;
            string kerkuesIban = parentForm?.UserIban;
            string marresIban = recipientIbanTextBox.Text.Trim();

            if (kerkuesIban == marresIban)
            {
                MessageBox.Show("Nuk mund t'i kërkoni para vetes suaj!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create money request with CORRECT column names
            string query = @"INSERT INTO kerkesat_para 
                    (iban, iban_marresit, shuma, mesazhi)
                    VALUES 
                    (@KerkuesIban, @MarresIban, @Shuma, @Message)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KerkuesIban", kerkuesIban);
                    command.Parameters.AddWithValue("@MarresIban", marresIban);
                    command.Parameters.AddWithValue("@Shuma", shumaKerkuar);
                    command.Parameters.AddWithValue("@Message", messageTextBox.Text.Trim());

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show($"Kërkesa për {shumaKerkuar:N2}? u dërgua me sukses!",
                                  "Sukses",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Gabim databaze: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateMoneyRequest(string kerkuesIban, string marresIban, decimal shuma, string mesazhi)
        {
            string query = @"INSERT INTO kerkesat_para 
                            (iban, iban_marresit, shuma, mesazhi)
                            VALUES 
                            (@KerkuesIban, @MarresIban, @Shuma, @Mesazhi)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KerkuesIban", kerkuesIban);
                    command.Parameters.AddWithValue("@MarresIban", marresIban);
                    command.Parameters.AddWithValue("@Shuma", shuma);
                    command.Parameters.AddWithValue("@Mesazhi", string.IsNullOrEmpty(mesazhi) ? DBNull.Value : mesazhi);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Kërkesa për {shuma:N2} është dërguar me sukses tek llogaria me IBAN: {marresIban}",
                                      "Sukses",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key violation
                {
                    MessageBox.Show("IBAN-i i marrësit nuk ekziston!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Gabim gjatë dërgimit të kërkesës: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim i papritur: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            recipientIbanTextBox.Text = "";
            amountTextBox.Text = "";
            messageTextBox.Text = "";
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // Check if Owner is set and is a menu form
            if (this.Owner != null && this.Owner is menu)
            {
                // Show the menu form again
                this.Owner.Show();
                // Close the current transfer form
                this.Close();
            }
            else
            {
                // Fallback in case Owner isn't set correctly
                menu menuForm = new menu("User", ""); // This is not ideal, but a fallback
                menuForm.Show();
                this.Close();
            }
        }

        private void recipientIbanTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add IBAN formatting as user types
            // Example: Auto-insert spaces every 4 characters
        }

    }
}