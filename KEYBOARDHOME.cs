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
    public partial class KEYBOARDHOME : Form
    {
        public KEYBOARDHOME()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAZERHUNT rraz = new RAZERHUNT();
            rraz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAZERHUNT rraz = new RAZERHUNT();
            rraz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAZERHUNT rraz = new RAZERHUNT();
            rraz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE hOMEPAGE = new HOMEPAGE();
            hOMEPAGE.Show();
        }
    }
}
