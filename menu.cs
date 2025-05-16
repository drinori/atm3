using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class menu : Form
    {
        private Panel panelHeader;
        private Label labelWelcome;
        private string userEmri;
        private string userIban;

        public menu(string emri, string iban)
        {
            InitializeComponent();
            userEmri = emri;
            userIban = iban;
            labelWelcome.Text = $"Miresevini, {emri}";
        }


        public string UserIban
        {
            get { return userIban; }
        }

        private void qkyqu_Click(object sender, EventArgs e)
        {
            dashboard qkyqu = new dashboard();
            qkyqu.Show();
            this.Hide();
        }

        private void deponim_Click(object sender, EventArgs e)
        {
            deponim deponim = new deponim();
            deponim.Owner = this; // Set the owner to pass the IBAN
            deponim.Show();
            this.Hide();
        }

        private void terheqja_Click(object sender, EventArgs e)
        {
            terheqje terheqja = new terheqje();
            terheqja.Owner = this; // Set the owner to pass the parent form
            terheqja.Show();
            this.Hide();
        }

        private void bilanci_Click(object sender, EventArgs e)
        {
            if (bilanci == null || bilanci.IsDisposed)
            {
                bilanci bilanci = new bilanci();
                bilanci.Owner = this;
                bilanci.Show();
                this.Hide();
            }
            else
            {
                bilanci.Show(); // If it's not disposed, just show it
            }
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            dergo dergo = new dergo();
            dergo.Owner = this;
            dergo.Show();
            this.Hide();
        }

        private void historiku_Click(object sender, EventArgs e)
        {
            historiku historyForm = new historiku(UserIban);
            historyForm.ShowDialog();
        }

        private void kerko_Click(object sender, EventArgs e)
        {
            kerko kerko = new kerko();
            kerko.Owner = this; // Set the owner to pass the IBAN
            kerko.Show();
            this.Hide();
        }

        private void mesazhet_Click(object sender, EventArgs e)
        {
            mesazhet mesazhet = new mesazhet(userIban);
            mesazhet.Owner = this; // Set the owner to pass the IBAN
            mesazhet.Show();
            this.Hide();
        }
    }
}