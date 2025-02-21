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
    public partial class MOUSEHOME : Form
    {
        public MOUSEHOME()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE hpp = new HOMEPAGE();
            hpp.Show();
        }
    }
}
