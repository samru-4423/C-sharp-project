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
    public partial class AdminEmployyeList : Form
    {
        public AdminEmployyeList()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string q = "select * from Employee";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //DataTable dt = ds.Tables[0];
            dataGridViewlistemp.AutoGenerateColumns = true;
            dataGridViewlistemp.DataSource = dt;
            conn.Close();
        }
        /*private void button6_Click(object sender, EventArgs e) // Log out
        {
            MessageBox.Show("Log out successfully");
            this.Hide();
            Loginadmin loginadmin = new Loginadmin();
            loginadmin.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Dashboard
        {
            this.Hide();
            AdminHomepage adminhp = new AdminHomepage();
            adminhp.Show();
        }*/

        /*private void button3_Click(object sender, EventArgs e) // Manager List
        {
            this.Hide();
            AdminManagerList adminml = new AdminManagerList();
            adminml.Show();
        }

        private void button5_Click(object sender, EventArgs e) // Register
        {
            //this.Hide();
            //AdminRegister adminRegister = new AdminRegister();
            //adminRegister.Show();
        }*/

        private void pictureBox1_Click(object sender, EventArgs e) // Back to Admin Homepage
        {
            this.Hide();
            AdminHomepage adminhp = new AdminHomepage();
            adminhp.Show();
        }

        private void dataGridViewlistemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdminEmployyeList_Load(object sender, EventArgs e) //Form
        {
            LoadData();
        }
    }
}
