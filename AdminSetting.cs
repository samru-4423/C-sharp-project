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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StartPage
{
    public partial class AdminSetting : Form
    {
        public AdminSetting()
        {
            InitializeComponent();
        }
        private void LoadData() 
        {
            string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string q = "select * from Adminpro";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e) // Back button
        {
            this.Hide();
            AdminHomepage adminHomepage = new AdminHomepage();
            adminHomepage.Show();
        }

        /*private void AdminSetting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empinfoDataSet.Adminpro' table. You can move, or remove it, as needed.
            this.adminproTableAdapter.Fill(this.empinfoDataSet.Adminpro);

        }*/

        private void btnlogin_Click(object sender, EventArgs e) // Update
        {
            if (tbadminid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                if (tbadminpass.Text != "")
                {
                    string q = "update Adminpro set Pass='" + tbadminpass.Text + "' where id=" + tbadminid.Text + "";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbadminpass.Clear();
                }
                else if (tbadminemail.Text != "")
                {
                    string q = "update Adminpro set Email='" + tbadminemail.Text + "' where id=" + tbadminid.Text + "";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbadminemail.Clear();
                }
                else if (tbadmincontact.Text != "")
                {
                    string q = "update Adminpro set Contact='" + tbadmincontact.Text + "' where id=" + tbadminid.Text + "";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbadmincontact.Clear();
                }
                else if (tbadminaddress.Text != "")
                {
                    string q = "update Adminpro set Address='" + tbadminaddress.Text + "' where id=" + tbadminid.Text + "";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbadminaddress.Clear();
                }
                //string q = "update Adminpro set Pass='" + tbadminpass.Text + "' Email='" + tbadminemail.Text + "' Contact='" + tbadmincontact.Text + "' Address='" + tbadminaddress.Text + "' where id=" + tbadminid.Text + "";
                //SqlCommand cmd = new SqlCommand(q, conn);
                //cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbadminid.Clear();
            }
            else
            {
                MessageBox.Show("Please select an ID first");
                tbadminname.Clear();
            }
        }

        private void AdminSetting_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Delete
        {
            if (tbadminid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "delete from Adminpro where Id = " + tbadminid.Text;
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbadminname.Clear();
                tbadminuname.Clear();
                tbadminid.Clear();
                tbadminpass.Clear();
                tbadmincontact.Clear();
                tbadminaddress.Clear();
                tbadminemail.Clear();
            }
            else
            {
                MessageBox.Show("Please select an ID first");
                tbadminname.Clear();
                tbadminuname.Clear();
                tbadminpass.Clear();
                tbadmincontact.Clear();
                tbadminaddress.Clear();
                tbadminemail.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Add
        {
            if (tbadminid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "insert into Adminpro values(" + tbadminid.Text + ", '" + tbadminname.Text + "', '" + tbadminuname.Text + "', '" + tbadminpass.Text + "', '" + tbadminemail.Text + "', '" + tbadmincontact.Text + "', '" + tbadminaddress.Text + "')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbadminname.Clear();
                tbadminuname.Clear();
                tbadminid.Clear();
                tbadminpass.Clear();
                tbadmincontact.Clear();
                tbadminaddress.Clear();
                tbadminemail.Clear();
            }
            else
            {
                MessageBox.Show("Please select an ID first");
                tbadminname.Clear();
                tbadminuname.Clear();
                tbadminpass.Clear();
                tbadmincontact.Clear();
                tbadminaddress.Clear();
                tbadminemail.Clear();
            }
        }
    }
}
