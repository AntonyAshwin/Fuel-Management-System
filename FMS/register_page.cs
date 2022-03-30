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
    public partial class register_page : UserControl
    {
        public register_page()
        {
            InitializeComponent();
        }
        public string conn_string = @"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=1234567Aa";
        SqlCommand cmd;
        
        private void register_page_Load(object sender, EventArgs e)
        {
            v_class.SelectedIndex = 1;
            f_type.SelectedIndex = 1;
        }

        private void register_vehicle(object sender, EventArgs e)
        {
            string l_num = l_number.Text;
            string r_num = r_number.Text;
            string vclass = v_class.Text;
            string ftype = f_type.Text;
            if (!all_fine(l_num, r_num))
                return;
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                try
                {
                    conn.Open();
                    String query = "insert into vehicle_details values('" + l_num + "','" + r_num + "','" + vclass + "','" + ftype + "',0);";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registration Successful");
                }
                catch (Exception)
                {
                    MessageBox.Show("Vehicle already exists");
                }
            }


        }
        
        private bool all_fine(string l_num, string r_num)
        {
            bool all_good = true;
            if (l_num.Length != 16)
            {
                l_error.Text = "Invalid License Number";
                all_good = false;
            }
            else l_error.Text = "";
            if (r_num.Length != 10)
            {
                r_error.Text = "Invalid Registration Number";
                all_good = false;
            }
            else r_error.Text = "";
            return all_good;
        }
       

    }
}
