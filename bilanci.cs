using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class bilanci : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";

        public bilanci()
        {
            InitializeComponent();
        }

        private void bilanci_Load(object sender, EventArgs e)
        {
            // Get the user's IBAN from the parent (menu) form
            menu parentForm = this.Owner as menu;
            if (parentForm != null && !string.IsNullOrEmpty(parentForm.UserIban))
            {
                string userIban = parentForm.UserIban;
                DisplayBalance(userIban);
            }
            else
            {
                MessageBox.Show("Could not retrieve account information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplayBalance(string iban)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT iban, bilanci FROM perdoruesit WHERE iban = @Iban";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Iban", iban);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Display account number and balance
                        label1.Text = $"Llogaria: {reader["iban"].ToString()}";

                        // Format the balance with two decimal places
                        decimal balance = Convert.ToDecimal(reader["bilanci"]);
                        label2.Text = $"Bilanci: {balance.ToString("0.00")} EUR";
                    }
                    else
                    {
                        // No matching record found
                        MessageBox.Show("Nuk u gjet llogari me këtë IBAN.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gabim në aksesimin e të dhënave: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Back button - return to menu
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                menu menuForm = new menu("", ""); // Fallback
                menuForm.Show();
                this.Close();
            }
        }
    }
}