using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public partial class dergo : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";

        public dergo()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            // Validate recipient IBAN
            if (string.IsNullOrWhiteSpace(marresiIBAN.Text))
            {
                MessageBox.Show("Ju lutem shkruani IBAN-in e marrësit!");
                return;
            }

            // Validate amount
            if (string.IsNullOrWhiteSpace(shuma.Text))
            {
                MessageBox.Show("Ju lutem shkruani një shumë për të transferuar!");
                return;
            }

            // Check if the amount is a valid number
            if (!float.TryParse(shuma.Text, out float shumaTransfer))
            {
                MessageBox.Show("Ju lutem shkruani një shumë valide!");
                return;
            }

            // Check if the amount is positive
            if (shumaTransfer <= 0)
            {
                MessageBox.Show("Ju lutem vendosni një shumë pozitive!");
                return;
            }

            // Get the current user's IBAN from the menu form
            menu parentForm = this.Owner as menu;
            string derguesiIban = parentForm.UserIban;
            string marresiIban = marresiIBAN.Text.Trim();

            // Don't allow transfer to the same account
            if (derguesiIban == marresiIban)
            {
                MessageBox.Show("Nuk mund të transferoni para në llogarinë tuaj!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if recipient IBAN exists
                    string kontrolloMarresIbanQuery = "SELECT COUNT(*) FROM perdoruesit WHERE iban = @MarresiIban";
                    SqlCommand kontrolloMarresIbanCmd = new SqlCommand(kontrolloMarresIbanQuery, connection);
                    kontrolloMarresIbanCmd.Parameters.AddWithValue("@MarresiIBAN", marresiIban);
                    int marresiEkziston = (int)kontrolloMarresIbanCmd.ExecuteScalar();

                    if (marresiEkziston == 0)
                    {
                        MessageBox.Show("IBAN-i i marrësit nuk ekziston!");
                        return;
                    }

                    // Check if sender has sufficient funds
                    string kontrolloBilancQuery = "SELECT bilanci FROM perdoruesit WHERE iban = @DerguesiIban";
                    SqlCommand kontrolloBilancCmd = new SqlCommand(kontrolloBilancQuery, connection);
                    kontrolloBilancCmd.Parameters.AddWithValue("@DerguesiIban", derguesiIban);
                    float bilanciAktual = Convert.ToSingle(kontrolloBilancCmd.ExecuteScalar());

                    if (bilanciAktual < shumaTransfer)
                    {
                        MessageBox.Show("Ju nuk keni mjete të mjaftueshme për këtë transferim!");
                        return;
                    }

                    // Get the message from the textbox
                    string userMessage = messagebox.Text.Trim();

                    // Start a transaction to ensure atomicity
                    using (SqlTransaction transaksioni = connection.BeginTransaction())
                    {
                        try
                        {
                            // 1. Deduct amount from sender
                            string deductQuery = "UPDATE perdoruesit SET bilanci = bilanci - @Shuma WHERE iban = @DerguesiIban";
                            SqlCommand deductCmd = new SqlCommand(deductQuery, connection, transaksioni);
                            deductCmd.Parameters.AddWithValue("@Shuma", shumaTransfer);
                            deductCmd.Parameters.AddWithValue("@DerguesiIBAN", derguesiIban);
                            deductCmd.ExecuteNonQuery();

                            // 2. Add amount to recipient
                            string addQuery = "UPDATE perdoruesit SET bilanci = bilanci + @Shuma WHERE iban = @MarresiIBAN";
                            SqlCommand addCmd = new SqlCommand(addQuery, connection, transaksioni);
                            addCmd.Parameters.AddWithValue("@Shuma", shumaTransfer);
                            addCmd.Parameters.AddWithValue("@MarresiIBAN", marresiIban);
                            addCmd.ExecuteNonQuery();

                            // 3. Get sender user ID
                            string merrDerguesIdQuery = "SELECT Id FROM perdoruesit WHERE iban = @DerguesiIban";
                            SqlCommand merrDerguesIdCmd = new SqlCommand(merrDerguesIdQuery, connection, transaksioni);
                            merrDerguesIdCmd.Parameters.AddWithValue("@DerguesiIban", derguesiIban);
                            int DerguesId = (int)merrDerguesIdCmd.ExecuteScalar();

                            // 4. Insert into transaction log for sender (outgoing transfer)
                            string insertoTransaksionDerguesitQuery = "INSERT INTO transaksionet (iban, tipi, shuma, iban_marresit, mesazhi, Tdata, perdoruesiID) " +
                                                   "VALUES (@DerguesiIban, @Tipi, @Shuma, @MarresiIBAN, @Mesazhi, GETDATE(), @DerguesId)";
                            SqlCommand insertoTransaksionDerguesitCmd = new SqlCommand(insertoTransaksionDerguesitQuery, connection, transaksioni);
                            insertoTransaksionDerguesitCmd.Parameters.AddWithValue("@DerguesiIban", derguesiIban);
                            insertoTransaksionDerguesitCmd.Parameters.AddWithValue("@Tipi", "Transferim");
                            insertoTransaksionDerguesitCmd.Parameters.AddWithValue("@Shuma", shumaTransfer);
                            insertoTransaksionDerguesitCmd.Parameters.AddWithValue("@MarresiIBAN", marresiIban);
                            insertoTransaksionDerguesitCmd.Parameters.AddWithValue("@Mesazhi", userMessage);
                            insertoTransaksionDerguesitCmd.Parameters.AddWithValue("@DerguesId", DerguesId);
                            insertoTransaksionDerguesitCmd.ExecuteNonQuery();

                            // Commit the transaction
                            transaksioni.Commit();

                            // Show success message in a MessageBox
                            MessageBox.Show($"Transferimi u krye me sukses! Ju keni transferuar {shumaTransfer} tek llogaria me IBAN: {marresiIBAN}");

                            // Clear the input fields
                            marresiIBAN.Text = "";
                            shuma.Text = "";
                            messagebox.Text = ""; // Clear the message box
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if something goes wrong
                            transaksioni.Rollback();
                            MessageBox.Show("Ka ndodhur një gabim gjatë transferimit: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ka ndodhur një gabim me lidhjen e databazës: " + ex.Message);
                }
            }
        }

        private void kthehu_Click(object sender, EventArgs e)
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
    }
}