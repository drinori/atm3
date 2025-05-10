using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace atm
{
    public partial class kyqja : Form
    {
        public kyqja()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";


        private void Kyqu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT emri, iban FROM perdoruesit WHERE iban = @Iban AND pin = @Pin";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Iban", textBox1.Text);
                        command.Parameters.AddWithValue("@Pin", textBox2.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string emri = reader["emri"].ToString();
                                string iban = reader["iban"].ToString();

                                // Pass both name and IBAN to the menu form
                                menu menuForm = new menu(emri, iban);
                                menuForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Iban ose PIN i gabuar.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ndodhi nje gabim: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regjistrimi regjistrimi = new regjistrimi();
            regjistrimi.Show();
            this.Hide();
        }
    }
}