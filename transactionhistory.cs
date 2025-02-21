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
    public partial class transactionhistory : Form
    {
        public transactionhistory()
        {
            InitializeComponent();
        }
        private void LoadData() //Load function
        {
            string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            string q = "select * from Transactions";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           TRANSACTION   trans = new TRANSACTION();
            trans.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //LoadData();
        }

        private void transactionhistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (tbsearch.Text != "")
            {
                string connstring = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();
                string q = "select * from Transactions where Billno=" + tbsearch.Text + "";
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
            else
            {
                MessageBox.Show("Invalid billno");
            }
        }
    }
}
