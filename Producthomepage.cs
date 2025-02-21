using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class Producthomepage : Form
    {
        public Producthomepage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e) //Admin Homepage
        {
            this.Hide();
            AdminHomepage hp = new AdminHomepage();
            hp.Show();
        }

        private void button12_Click(object sender, EventArgs e) // Product Homepage 2
        {
            this.Hide();
            Producthomepage2 ph2 = new Producthomepage2();
            ph2.Show();
        }
    }
}
