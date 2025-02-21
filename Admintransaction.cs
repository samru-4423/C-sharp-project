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
    public partial class Admintransaction : Form
    {
        public Admintransaction()
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
            dataGridViewadt.AutoGenerateColumns = true;
            dataGridViewadt.DataSource = dt;
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomepage ahom = new AdminHomepage();
            ahom.Show();
        }

        private void dataGridViewadt_CellContentClick(object sender, DataGridViewCellEventArgs e) //Load function
        {
            //LoadData();
        }

        private void Admintransaction_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
