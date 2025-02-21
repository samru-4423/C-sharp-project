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
    public partial class HARDDISK : Form
    {
        public HARDDISK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE hOMEPAGE = new HOMEPAGE();
            hOMEPAGE.Show();
        }
    }
}
