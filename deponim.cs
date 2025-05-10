using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class deponim : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";

        public deponim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ju lutem shkruani një shumë për të depozituar!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the input is a valid number
            if (!float.TryParse(textBox1.Text, out float shumaDepozituar))
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the amount is positive
            if (shumaDepozituar <= 0)
            {
                MessageBox.Show("Ju lutem vendosni një shumë pozitive!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                // Get the current user's IBAN from the menu form
                menu parentForm = this.Owner as menu;
            string userIban = parentForm.UserIban;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // 1. Update user balance
                string updateBilancinQuery = "UPDATE perdoruesit SET bilanci = bilanci + @Shuma WHERE iban = @Iban";
                SqlCommand updateBilancinCmd = new SqlCommand(updateBilancinQuery, connection);
                updateBilancinCmd.Parameters.AddWithValue("@Shuma", shumaDepozituar);
                updateBilancinCmd.Parameters.AddWithValue("@Iban", userIban);
                updateBilancinCmd.ExecuteNonQuery();

                // 2. Get user ID
                string merrUserIdQuery = "SELECT Id FROM perdoruesit WHERE iban = @Iban";
                SqlCommand merrUserIdCmd = new SqlCommand(merrUserIdQuery, connection);
                merrUserIdCmd.Parameters.AddWithValue("@Iban", userIban);
                int userId = (int)merrUserIdCmd.ExecuteScalar();

                // 3. Insert into transaction log
                string insertTransaksionQuery = "INSERT INTO transaksionet (iban, tipi, shuma, Tdata, perdoruesiID) " +
                                               "VALUES (@Iban, @Tipi, @Shuma, GETDATE(), @UserId)";
                SqlCommand insertTransaksionCmd = new SqlCommand(insertTransaksionQuery, connection);
                insertTransaksionCmd.Parameters.AddWithValue("@Iban", userIban);
                insertTransaksionCmd.Parameters.AddWithValue("@Tipi", "Depozitim");
                insertTransaksionCmd.Parameters.AddWithValue("@Shuma", shumaDepozituar);
                insertTransaksionCmd.Parameters.AddWithValue("@UserId", userId);
                insertTransaksionCmd.ExecuteNonQuery();

                MessageBox.Show("Depozitimi u krye me sukses!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if Owner is set and is a menu form
            if (this.Owner != null && this.Owner is menu)
            {
                // Show the menu form again
                this.Owner.Show();

                // Close the current deposit form
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
    }
}