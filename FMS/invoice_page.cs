using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FMS
{
   
    public partial class invoice_page : UserControl
    {

        public static string conn = @"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=1234567Aa";

        SqlConnection con = new SqlConnection(conn);
        public string g_id { get; set; }
        public invoice_page()
        {
            InitializeComponent();
        }

        private void invoice_page_Load(object sender, EventArgs e)
        {

        }

        private void retrieve_refresh(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from invoice where g_id = '"+g_id+"' order by invoice_date asc, invoice_time desc;", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void find_invoice_id(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(conn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from invoice where g_id = '" + g_id + "' and invoice_id = '" + int.Parse(invoice_id.Text) + "'  order by invoice_date asc, invoice_time desc;", con1);
                    DataTable dt = new DataTable();
                    con1.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                    con1.Close();
                    dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {

                }
            }
        }

        private void find_rnumber(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from invoice where g_id = '" + g_id + "' and number_plate = '" + invoice_id.Text + "'  order by invoice_date asc, invoice_time desc;", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void find_lnumber(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select g_id,fuel_amount, i.number_plate, invoice_time, purchase_amt, invoice_date, invoice_id from invoice i, vehicle_details v where i.number_plate = v.number_plate and license_number =  '"+invoice_id.Text+ "' and g_id = '"+g_id+"' order by invoice_date asc, invoice_time desc;", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
