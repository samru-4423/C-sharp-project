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
    public partial class Producthomepage2 : Form
    {
        public Producthomepage2()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e) //Admin Homepage
        {
            this.Hide();
            AdminHomepage hp = new AdminHomepage();
            hp.Show();
        }

        private void button7_Click(object sender, EventArgs e) // Back
        {
            this.Hide();
            Producthomepage ph = new Producthomepage();
            ph.Show();
        }

        private void button12_Click(object sender, EventArgs e) // Next
        {
            this.Hide();
            Producthomepage3 ph3 = new Producthomepage3();
            ph3.Show();
        }
    }
}
