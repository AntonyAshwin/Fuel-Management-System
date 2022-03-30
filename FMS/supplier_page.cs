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

    public partial class supplier_page : UserControl
    {
        public string conn = @"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=yourpassword";
        public string g_id { get; set; }
      
        public supplier_page()
        {
            InitializeComponent();
            

        }

        private void supplier_page_Load(object sender, EventArgs e)
        {
        
        }

        private void get_supplier_details(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox2.Show();
            groupBox2.BringToFront();
            String query = "select * from supplier join gas_station on g_id = '"+g_id+"' and gas_station.supplier = supplier.supplier_name;";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            DataRow[] g_rows = dtable.Select();
            supp_name.Text = g_rows[0]["supplier_name"].ToString();
            prate.Text = g_rows[0]["supplier_petrol_price"].ToString();
            drate.Text = g_rows[0]["supplier_diesel_price"].ToString();
            supp_email.Text = g_rows[0]["supplier_email"].ToString();
        }

        private void refill_button(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
            groupBox3.BringToFront();
            groupBox2.BringToFront();
            String query = "select * from supplier join gas_station on g_id = '" + g_id + "' and gas_station.supplier = supplier.supplier_name;";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            DataRow[] g_rows = dtable.Select();
            int refill_status = int.Parse(g_rows[0]["refill"].ToString());
            string last_order_date = g_rows[0]["last_order_date"].ToString();
            DialogResult dialogResult = MessageBox.Show("Proceeding with yes will send an automated Silo Refill Request", "Warning !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (refill_status == 1)
                {
                    status_info.Text = "You have already requested for a refill on '" + last_order_date + "'";
                }
                else
                {
                    status_info.Text = "Refill request will be attended to in 2-3 working days\n" +
                        "Supplier Name   : '" + g_rows[0]["supplier"].ToString() + "'\n" +
                        "Request Status  : Yet to Deliver";

                    SqlConnection conn1 = new SqlConnection(conn);
                    SqlCommand cmd;
                    conn1.Open();
                    String query1 = "update gas_station set last_order_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', refill = 1, petrol_curr = petrol_max, diesel_curr = diesel_max where g_id = '" + g_id + "'";
                    cmd = new SqlCommand(query1, conn1);
                    cmd.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Refill request sent.");
                }
            }
            else
            {
                status_info.Text = " ";
            }
        }

        private void clear_refill_request(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(conn);
            SqlCommand cmd;
            conn1.Open();
            String query1 = "update gas_station set refill = 0 where g_id = '" + g_id + "'";
            cmd = new SqlCommand(query1, conn1);
            cmd.ExecuteNonQuery();
            conn1.Close();
            MessageBox.Show("Your refill request has been cleared.");
            status_info.Text = " ";
        }
    }
}
