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
    public partial class options_page : UserControl
    {
        public string conn_string = @"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=yourpasword";
     
        SqlCommand cmd;
        public void clear_text()
        {
            new_pass_err.Text = "";
            confirm_new_pass_err.Text = "";
            curr_pass_err.Text = "";
        } 

        public bool all_good()
        {
            bool check = true;
            if(new_pass.Text.Length < 5)
            {
                new_pass_err.Text = "Password length must be greater than 5 characters";
                check = false;
            }
            if(new_pass.Text != confirm_new_pass.Text)
            {
                confirm_new_pass_err.Text = "Passwords not matching";
                check = false;
            }
            if(curr_pass.Text == "")
            {
                check = false;
                curr_pass_err.Text = "Current password is empty";
               
            }
   
            return check;
        }


      public string g_id { get; set; }
      public double g_curr_petrol { get; set; }
      public double g_curr_diesel { get; set; }

        public options_page()
        {
            InitializeComponent();
        }

        private void change_pass(object sender, EventArgs e)
        {
            clear_text();
            if (all_good())
            {
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    String querry = "Select * from gas_station where g_id = '" + g_id + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    DataRow[] g_rows = dtable.Select();
                    if (curr_pass.Text == g_rows[0]["g_pass"].ToString())
                    {
                        //update
                        conn.Open();
                        String query = "update gas_station set g_pass = '" + new_pass.Text + "' where g_id = '" + g_id + "';";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        pass_change.Text = "Password changed";
                    }
                    else
                    {
                        curr_pass_err.Text = "Incorrect Password";
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void options_page_Load(object sender, EventArgs e)
        {
            update_petrol_err.Text = "";
            update_diesel_err.Text = "";
        }

        private void update_pmax(object sender, EventArgs e)
        {
            double value;
            if (update_petrol.Text == "")
            {
                update_petrol_err.ForeColor = Color.Red;
                update_petrol_err.Text = "Invalid Input";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    try
                    {
                        value = double.Parse(update_petrol.Text);
                       

                        conn.Open();
                        String query = "update gas_station set petrol_max = '" + value + "' where g_id = '" + g_id + "'";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        update_petrol_err.ForeColor = Color.Green;
                        update_petrol_err.Text = "Capacity updated";
                    }
                    catch (Exception)
                    {
                        update_petrol_err.ForeColor = Color.Red;
                        update_petrol_err.Text = "Invalid Input";
                    }
                }

            }
        }

        private void update_dmax(object sender, EventArgs e)
        {
            double value;
            if (update_diesel.Text == "")
            {
                update_diesel_err.ForeColor = Color.Red;
                update_diesel_err.Text = "Invalid Input";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    try
                    {
                        value = double.Parse(update_diesel.Text);
                        
                        conn.Open();
                        String query = "update gas_station set diesel_max = '" + value + "' where g_id = '" + g_id + "'";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        update_diesel_err.ForeColor = Color.Green;
                        update_diesel_err.Text = "Capacity updated";
                    }
                    catch (Exception)
                    {
                        update_diesel_err.ForeColor = Color.Red;
                        update_diesel_err.Text = "Invalid Input";
                    }

                }
            }
        }
    }
}
