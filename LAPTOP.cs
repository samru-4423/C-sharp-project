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
    public partial class LAPTOP : Form
    {
        public LAPTOP()
        {
            InitializeComponent();
        }

        private void LAPTOP_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LAPTOPNT laptopint = new LAPTOPNT();    
            laptopint.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asusrog asusrog = new Asusrog();
            asusrog.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE hOMEPAGE = new HOMEPAGE();
            hOMEPAGE.Show();
        }
    }
}
