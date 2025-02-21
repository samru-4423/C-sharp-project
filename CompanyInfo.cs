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
    public partial class CompanyInfo : Form
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Back to Admin Homepage
        {
            this.Hide();
            AdminHomepage adminHomepage = new AdminHomepage();
            adminHomepage.Show();
        }
    }
}
