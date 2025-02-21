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
    public partial class Loginemployee : Form
    {
        public Loginemployee()
        {
            InitializeComponent();
        }

        //sql connection with database 'Inventory'
        SqlConnection conn = new SqlConnection(@"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True");
        private void btnlogin_Click(object sender, EventArgs e) // Log in
        {
                string tbeuname = tbempuname.Text;
                string tbepass = tbemppass.Text;

                try
                {
                    string q = "select * from Employee where Username = '" + tbempuname.Text + "' AND Password = '" + tbemppass.Text + "'";
                    //SqlCommand cmd = new SqlCommand(q, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(q, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        tbeuname = tbempuname.Text;
                        tbepass = tbemppass.Text;

                        MessageBox.Show("Login successfully");
                        this.Hide();    
                        HOMEPAGE hp = new HOMEPAGE();
                        hp.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and password");
                        tbempuname.Clear();
                        tbemppass.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                    tbempuname.Clear();
                    tbemppass.Clear();
                }
                finally
                {
                    conn.Close();
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

        private void pictureBox2_Click(object sender, EventArgs e) // Back
        {
            this.Hide();
            Startpage stpage = new Startpage();
            stpage.Show();
        }
    }
}
