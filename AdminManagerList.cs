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
    public partial class AdminManagerList : Form
    {
        public AdminManagerList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // Log out
        {
            MessageBox.Show("Log out successfully");
            this.Hide();
            Loginadmin loginadmin = new Loginadmin();
            loginadmin.Show();
        }

        private void button4_Click(object sender, EventArgs e) // Employee List
        {
            this.Hide();
            AdminEmployyeList adminel = new AdminEmployyeList();
            adminel.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Manager List
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // Dashboard
        {
            this.Hide();
            AdminHomepage adminhp = new AdminHomepage();
            adminhp.Show();
        }

        private void button5_Click(object sender, EventArgs e) // Register
        {
            this.Hide();
            AdminRegister adminRegister = new AdminRegister();
            adminRegister.Show();
        }
    }
}
