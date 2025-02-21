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
    public partial class Startpage : Form
    {
        public Startpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Admin Login
        {
            this.Hide();
            Loginadmin lgadmin = new Loginadmin();
            lgadmin.Show();
        }

        private void button3_Click(object sender, EventArgs e) //Employee Login
        {
            this.Hide();
            Loginemployee lgemployee = new Loginemployee();
            lgemployee.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Exit
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
