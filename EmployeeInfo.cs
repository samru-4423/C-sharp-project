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
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
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
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e) // Back to Admin Homepage
        {
            this.Hide();
            AdminHomepage adminHomepage = new AdminHomepage();
            adminHomepage.Show();
        }

        private void cbposition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //List
        {
            this.Hide();
            AdminEmployyeList adminEmployyeList = new AdminEmployyeList();
            adminEmployyeList.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Add
        {
            if (tbeid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "insert into Employee values('" + tbeid.Text + "','" + tbename.Text + "', '" + cbposition.Text + "', '" + tbeemail.Text + "', '" + tbecontact.Text + "', '" + cbdid.Text + "', '" + cbdname.Text + "', '" + tbeuname.Text + "', '" + tbepass.Text + "', " + tbesalary.Text + ", '" + tbeaddress.Text + "', '" + tbjoindate.Text + "')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbename.Text = "";
                tbeid.Text = "";
                cbdname.Text = "";
                cbdid.Text = "";
                tbeuname.Text = "";
                tbepass.Text = "";
                cbposition.Text = "";
                tbesalary.Text = "";
                tbeemail.Text = "";
                tbecontact.Text = "";
                tbeaddress.Text = "";
                tbjoindate.Text = "";
                MessageBox.Show("Data added");
            }
            else
            {
                MessageBox.Show("Please select an Employee ID first");
                tbename.Text = "";
                tbeid.Text = "";
                cbdname.Text = "";
                cbdid.Text = "";
                tbeuname.Text = "";
                tbepass.Text = "";
                cbposition.Text = "";
                tbesalary.Text = "";
                tbeemail.Text = "";
                tbecontact.Text = "";
                tbeaddress.Text = "";
                tbjoindate.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e) //Delete
        {
            if (tbeid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "delete from Employee where EmployeeID = '" + tbeid.Text+"'";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbeid.Clear();
                MessageBox.Show("Data deleted");
            }
            else
            {
                MessageBox.Show("Please select Employee ID first");
                tbeid.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Update
        {
            if (tbeid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                if (tbepass.Text != "")
                {
                    string q = "update Employee set Password='" + tbepass.Text + "' where EmployeeID='" + tbeid.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbepass.Clear();
                }
                else if (cbposition.Text != "" && tbesalary.Text !="")
                {
                    string q = "update Employee set Position='" + cbposition.Text + "', Salary =" + tbesalary.Text + "where EmployeeID='" + tbeid.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbesalary.Clear();
                    cbposition.Text = "";
                }
                else if (tbeemail.Text != "" && tbecontact.Text != "")
                {
                    string q = "update Employee set Email='" + tbeemail.Text + "', Contact =" + tbecontact.Text + " where EmployeeID='" + tbeid.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbeemail.Clear();
                    tbecontact.Clear();
                }
                else if (tbeaddress.Text != "")
                {
                    string q = "update Employee set Address='" + tbeaddress.Text + "' where EmployeeID='" + tbeid.Text + "'";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    tbeaddress.Clear();
                }
                tbeid.Clear();
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Please select an Item ID first");
                tbeid.Clear();
            }
        }
    }
}
