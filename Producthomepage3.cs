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
    public partial class Producthomepage3 : Form
    {
        public Producthomepage3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e) // Back
        {
            this.Hide();
            Producthomepage2 ph2 = new Producthomepage2();
            ph2.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e) // Home
        {
            this.Hide();
            HOMEPAGE hp = new HOMEPAGE();
            hp.Show();
        }
    }
}
