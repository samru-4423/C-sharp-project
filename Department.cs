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
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string q = "select * from Dept_Item";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //DataTable dt = ds.Tables[0];
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = dt;
            conn.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e) // Back to Admin Homepage
        {
            this.Hide();
            AdminHomepage adminhp = new AdminHomepage();
            adminhp.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Assign 
        {
            if (cmbDepartmentID.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "insert into Dept_Item values(" + tbserial.Text + ",'" + cmbDepartmentName.Text + "', '" + cmbDepartmentID.Text + "', '" + cmbFloor.Text + "', '" + cmbItemID.Text + "', '" + tbItemName.Text + "', '"+ cmbCategory.Text + "')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                cmbDepartmentID.Text = "";
                cmbDepartmentName.Text = "";
                cmbFloor.Text = "";
                tbItemName.Text = "";
                cmbItemID.Text = "";
                cmbCategory.Text = "";
                tbserial.Text = "";
            }
            else
            {
                MessageBox.Show("Please select an Department ID first");
                cmbDepartmentID.Text = "";
                cmbDepartmentName.Text = "";
                cmbFloor.Text = "";
                tbItemName.Text = "";
                cmbItemID.Text = "";
                cmbCategory.Text = "";
                tbserial.Text = "";
            }
        }

        

        private void button3_Click(object sender, EventArgs e) // Delete
        {
            if (tbserial.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "delete from Dept_Item where Serial=" + tbserial.Text + "" ;
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbserial.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a Serial No. first");
                tbserial.Text = "";
            }
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
