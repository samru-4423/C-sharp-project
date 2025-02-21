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
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }
        private void LoadData() //Load function
        {
            string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string q = "select * from Item";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //DataTable dt = ds.Tables[0];
            dataGridViewItem.AutoGenerateColumns = true;
            dataGridViewItem.DataSource = dt;
            conn.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e) // Back to Admin Homepage
        {
            this.Hide();
            AdminHomepage adminhp = new AdminHomepage();
            adminhp.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Add
        {
            try
            {
                if(tbitemid.Text !="")
                {
                    string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string q = "insert into Item values(" + tbitemid.Text + ", '" + tbitemname.Text + "', '" + cmbItemcode.Text + "', '" + cmbCategory.Text + "', " + cmbQuantity.Text + ", '" + cmbCondition.Text + "')";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                }
            }
            catch 
            {
                MessageBox.Show("Item ID must be unique");
            }
            finally
            {
                this.Show();
            }
        }
        private void FormInventory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnlogin_Click(object sender, EventArgs e) // Update
        {
            if (tbitemid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "update Item set Quantity=" + cmbQuantity.Text + ", Condition='" + cmbCondition.Text + "' where ItemID=" + tbitemid.Text + "";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbitemid.Clear();
                cmbQuantity.Text = "";
                cmbCondition.Text = "";
            }
            else
            {
                MessageBox.Show("Please select an Item ID first");
                tbitemid.Clear();
                cmbQuantity.Text = "";
                cmbCondition.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) //Delete
        {
            if (tbitemid.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "delete from Item where ItemID = " + tbitemid.Text;
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tbitemid.Clear();
            }
            else
            {
                MessageBox.Show("Please select an ID first");
                tbitemid.Clear();
            }
        }
    }
}
