using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class Loginadmin : Form
    {
        public Loginadmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //Back button
        {
            this.Hide();
            Startpage stpage = new Startpage();
            stpage.Show();
        }

        //sql connection with database 'Inventory'
        SqlConnection conn = new SqlConnection(@"Data Source=samru\sqlexpress;Initial Catalog=FinalProject;Integrated Security=True");
        private void btnlogin_Click(object sender, EventArgs e) // Log in
        {
            string tbaduname = tbadminuname.Text;
            string tbadpass = tbadminpass.Text;

            try
            {
                string q = "select * from Adminpro where Username = '" + tbadminuname.Text + "' AND Pass = '" + tbadminpass.Text + "'";
                //SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter sda = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    tbaduname = tbadminuname.Text;
                    tbadpass = tbadminpass.Text;

                    MessageBox.Show("Login successfully");
                    AdminHomepage adminHomepage = new AdminHomepage();
                    adminHomepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                    tbadminuname.Clear();
                    tbadminpass.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
                tbadminuname.Clear();
                tbadminpass.Clear();
            }
            finally
            {
                this.Hide();
            }

            /*if (tbaduname=="" && tbadpass == "") 
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                MessageBox.Show("Welcome admin");
                this.Hide();
                AdminHomepage adminhp = new AdminHomepage();
                adminhp.Show();
            }*/
            
        }
    }
}
