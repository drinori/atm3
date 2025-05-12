using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regjistrimi regjistrimi = new regjistrimi();
            regjistrimi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kyqja kyqja = new kyqja();
            kyqja.Show();
            this.Hide();
        }
    }
}
