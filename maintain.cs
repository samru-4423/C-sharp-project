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
    public partial class maintain : Form
    {
        public maintain()
        {
            InitializeComponent();
        }
        private void LoadData() //Load function
        {
            string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string q = "select * from Maintenance";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //DataTable dt = ds.Tables[0];
            dataGridViewMain.AutoGenerateColumns = true;
            dataGridViewMain.DataSource = dt;
            conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Add
        {
            try
            {
                if (tbmainid.Text != "")
                {
                    string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string q = "insert into Maintenance values(" + tbmainid.Text + ", " + tbbill.Text + ", '" + cbitemcode.Text + "', '" + cbissue.Text + "', '" + cbresolution.Text + "', '" + tbstatus.Text + "'," + tbmamount.Text + ", '" + tbmdate.Text + "')";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("Added");
                    tbmainid.Clear();
                    tbbill.Clear();
                    cbitemcode.Text="";
                    cbissue.Text="";
                    cbresolution.Text="";
                    tbstatus.Clear();
                    tbmamount.Clear();
                    tbmdate.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Bill number must be unique");
            }
            finally
            {
                this.Show();
            }
        }

        private void cbissue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Update
        {
            if (tbmainid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "update Maintenance set Status='" + tbstatus.Text + "' where MaintenanceID=" + tbmainid.Text + "";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbmainid.Clear();
                tbstatus.Clear();
            }
            else
            {
                MessageBox.Show("Please select an Item ID first");
                tbmainid.Clear();
                tbstatus.Clear();
            }
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void pictureBox2_Click(object sender, EventArgs e) // BACK button
        {
            this.Hide();
            AdminHomepage adminHomepage = new AdminHomepage();  
                    
            adminHomepage.Show();
        }
    }
}
