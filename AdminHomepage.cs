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
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Dashboard
        {
            
        }

        private void button6_Click(object sender, EventArgs e) // Log out
        {
            /*MessageBox.Show("Log out successfully");
            this.Hide();
            Loginadmin loginadmin = new Loginadmin();
            loginadmin.Show();*/
        }

        /*private void button5_Click(object sender, EventArgs e) // Register
        {
            this.Hide();
            AdminRegister adminRegister = new AdminRegister();
            adminRegister.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Manager List
        {
            this.Hide();
            AdminManagerList adminml = new AdminManagerList();
            adminml.Show();
        }*/

        private void button4_Click(object sender, EventArgs e) // Employee List
        {
            this.Hide();
            AdminEmployyeList adminel = new AdminEmployyeList();
            adminel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Log out
        {
            //MessageBox.Show("Log out successfully");
            DialogResult result;
            result = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                Loginadmin loginadmin = new Loginadmin();
                loginadmin.Show();
            }
            else
            {
                this.Show();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Setting
        {
            this.Hide();
            AdminSetting adminSetting = new AdminSetting();
            adminSetting.Show();
        }

        private void button6_Click_1(object sender, EventArgs e) // Employee Info
        {
            this.Hide();
            EmployeeInfo empinfo = new EmployeeInfo();  
            empinfo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) // Department Information
        {
            this.Hide();
            FormDepartment formdept = new FormDepartment();
            formdept.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Item Info
        {
            this.Hide();
            FormInventory forminventory = new FormInventory();
            forminventory.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Product Homepage
        {
            this.Hide();
            Producthomepage ph1 = new Producthomepage();
            ph1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Company Info
        {
            this.Hide();
            CompanyInfo companyinfo = new CompanyInfo();
            companyinfo.Show();
        }

        private void button5_Click(object sender, EventArgs e) // Transaction 
        {
            this.Hide();
            Admintransaction atrans = new Admintransaction();
            atrans.Show();
        }

        private void button7_Click(object sender, EventArgs e) // Maintenance
        {
            this.Hide();
            maintain MAINtain = new maintain();
            MAINtain.Show();
            
        }
    }
}
