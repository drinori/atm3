using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class terheqje : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";

        public terheqje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ju lutem shkruani një shumë për të tërhequr!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(textBox1.Text, out float shumaTerheqjes))
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (shumaTerheqjes <= 0)
            {
                MessageBox.Show("Shuma e tërheqjes duhet të jetë pozitive!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the current user's IBAN from the parent (menu) form
            menu parentForm = this.Owner as menu;
            string userIban = parentForm.UserIban;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 1. Check current balance
                string merrBilancinQuery = "SELECT bilanci FROM perdoruesit WHERE iban = @Iban";
                SqlCommand merrBilancinCmd = new SqlCommand(merrBilancinQuery, connection);
                merrBilancinCmd.Parameters.AddWithValue("@Iban", userIban);
                float bilanciAktual = Convert.ToSingle(merrBilancinCmd.ExecuteScalar());

                // 2. Validate sufficient balance
                if (shumaTerheqjes > bilanciAktual)
                {
                    MessageBox.Show("Fonde të pamjaftueshme!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Update balance
                string updateBilancQuery = "UPDATE perdoruesit SET bilanci = bilanci - @Shuma WHERE iban = @Iban";
                SqlCommand updateBilancCmd = new SqlCommand(updateBilancQuery, connection);
                updateBilancCmd.Parameters.AddWithValue("@Shuma", shumaTerheqjes);
                updateBilancCmd.Parameters.AddWithValue("@Iban", userIban);
                updateBilancCmd.ExecuteNonQuery();

                // 4. Get user ID for transaction log
                string merrUserIdQuery = "SELECT Id FROM perdoruesit WHERE iban = @Iban";
                SqlCommand merrUserIdCmd = new SqlCommand(merrUserIdQuery, connection);
                merrUserIdCmd.Parameters.AddWithValue("@Iban", userIban);
                int userId = (int)merrUserIdCmd.ExecuteScalar();

                // 5. Record transaction
                string insertTransaksionQuery = "INSERT INTO transaksionet (iban, tipi, shuma, Tdata, perdoruesiID) " +
                                              "VALUES (@Iban, @Tipi, @Shuma, GETDATE(), @UserId)";
                SqlCommand insertTransaksionCmd = new SqlCommand(insertTransaksionQuery, connection);
                insertTransaksionCmd.Parameters.AddWithValue("@Iban", userIban);
                insertTransaksionCmd.Parameters.AddWithValue("@Tipi", "Tërheqje");
                insertTransaksionCmd.Parameters.AddWithValue("@Shuma", shumaTerheqjes);
                insertTransaksionCmd.Parameters.AddWithValue("@UserId", userId);
                insertTransaksionCmd.ExecuteNonQuery();

                MessageBox.Show("Tërheqja u krye me sukses!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.Owner != null && this.Owner is menu)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                menu menuForm = new menu("User", ""); // Fallback
                menuForm.Show();
                this.Close();
            }
        }
    }
}