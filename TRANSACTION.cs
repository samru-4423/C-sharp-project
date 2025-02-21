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
    public partial class TRANSACTION : Form
    {
        public TRANSACTION()
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
            dataGridViewtrans.AutoGenerateColumns = true;
            dataGridViewtrans.DataSource = dt;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)    //transaction form
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            transactionhistory Transactionhistory = new transactionhistory();
            Transactionhistory.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OTP oTP = new OTP();    
            oTP.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE homepage = new HOMEPAGE();
            homepage.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOMEPAGE hOMEPAGE = new HOMEPAGE();
            hOMEPAGE.Show();
        }

        private void button1_Click(object sender, EventArgs e)   //ADD
        {
            try
            {
                if (tprobill.Text != "")
                {
                    string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    string q = "insert into Transactions values(" + tprobill.Text + ", '" + tproname.Text + "', '" + tbempname.Text + "', '" + tbempid.Text + "', " + tproprice.Text + ", " + tproquantity.Text + ","+ ttpri.Text + ")";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    MessageBox.Show("ITEM ADDED");
                }
            }
            catch
            {
                MessageBox.Show("BILL NUMBER MUSTBE UNIQE");
            }
            finally
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) // delete
        {
            if (tprobill.Text != "")
            {
                string connectionString = @"Data Source=samru\sqlexpress;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string q = "delete from Transactions where Billno = " + tprobill.Text;
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
                tprobill.Clear();
                MessageBox.Show("ITEM DELETED");
            }
            else
            {
                MessageBox.Show("Please select an ID first");
                tprobill.Clear();
            }
        }

        private void tproquantity_TextChanged(object sender, EventArgs e) //Quantity textbox ---> total price calculate
        {
            double price, qty, totalprice;

            double.TryParse(tproprice.Text, out price);
            double.TryParse(tproquantity.Text, out qty);

            totalprice = price * qty;
            ttpri.Text = totalprice.ToString();
        }

        private void dataGridViewtrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
