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
    
    public partial class employee_page : UserControl
    {
        public string g_id { get; set; }

        string time = DateTime.Now.ToString("HH:mm:ss");
       
        
        public employee_page()
        {
            InitializeComponent();
             
    }

        double salary;

        string con_string = @"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=1234567Aa";
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=1234567Aa");
        SqlCommand cmd;
        private void employee_page_Load(object sender, EventArgs e)
        {
            delete_raise_group.Hide(); 
            add_group.Hide();
            designation.SelectedIndex=1;
        }

        private void refresh_data(object sender, EventArgs e)
        {
            clear_textfield();
            get_employee_list();
            employee_incharge();
        }



        public void employee_incharge()
        {
            try
            {
                String querry = "select * from employee where g_id = '" + g_id + "' and desig = 'pump_attendant' and '" + time + "' between duty_start and duty_end;";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con_string);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                DataRow[] g_rows = dtable.Select();
                curr_emp.Text = "[" + g_rows[0]["emp_id"].ToString() + "]  " + g_rows[0]["fname"].ToString() + " " +  g_rows[0]["lname"].ToString();
            }
            catch (Exception)
            {
                curr_emp.Text = "No employee assigned for now";
               
            }
        }




        public void get_employee_list()
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                SqlCommand cmd = new SqlCommand("select * from employee where g_id = '" + g_id + "';", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured in retrieving data ");
            }
        }

        private void add_employee(object sender, EventArgs e)
        {
            delete_raise_group.Hide();
            delete_raise_group.SendToBack();
            add_group.Text = "Add Employee";
            add_group.Show();
            add_group.BringToFront();
            clear_textfield();
            confirm_and_update.Hide();
            confirm_and_add.Show();
            confirm_and_add.BringToFront();
            update2.Hide();
        }


        public void clear_textfield()
        {
            e_id.Clear();
            fname.Clear();
            lname.Clear();
            cnum.Clear();
            dstart.Clear();
            dend.Clear();
            sal.Clear();
  
            e_id_err.Text = " ";
            fname_err.Text = " ";
            lname_err.Text = " ";
            cnum_err.Text = " ";
            dstart_err.Text = " ";
            dend_err.Text = " ";
            sal_err.Text = " ";
        }

        public bool all_good()
        {
            
            bool all_right = true;
            String querry = "Select * from employee where g_id = '" + g_id + "' AND emp_id = '" + e_id.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con_string);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0 || e_id.Text == "")
            {
                e_id_err.Text = "X";
                all_right = false;
            }
            else
            {
                e_id_err.Text = "";
            }
            try
            {
                salary = double.Parse(sal.Text);
            }
            catch (Exception)
            {
                sal_err.Text = "X";
                all_right = false;
            }
            if(fname.Text == "" && lname.Text == "")
            {
                fname_err.Text = "X";
                lname_err.Text = "X";
                all_right = false;
            }
            else
            {
                fname_err.Text = "";
                lname_err.Text =  "";
            }
            querry = "Select * from employee where contact = '" + cnum.Text + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(querry, con_string);
            DataTable dtable1 = new DataTable();
            sda.Fill(dtable1);
            if (dtable1.Rows.Count > 0 || cnum.Text == "")
            {
                cnum_err.Text = "X";
                all_right = false;
            }
            else
            {
                cnum_err.Text = "";
            }

            return all_right;
        }

        private void add_employee_group(object sender, EventArgs e)
        {
            
            if (!all_good())
                return;

            using (SqlConnection conn1 = new SqlConnection(con_string)) {
            

                    try {
                        conn1.Open();
                        String query = "insert into employee values('" + e_id.Text + "','" + fname.Text + "','" + lname.Text + "', '" + g_id + "','" + salary + "','" + designation.Text + "','" + cnum.Text + "','" + dstart.Text + "','" + dend.Text + "');";
                        cmd = new SqlCommand(query, conn1);
                        cmd.ExecuteNonQuery();
                        conn1.Close();
                        MessageBox.Show("Data successfully inserted");
                    button1.PerformClick();
                }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid input");
                    }

              
            }

        }

        private void update_employee(object sender, EventArgs e)
        {
            delete_raise_group.Hide();
            delete_raise_group.SendToBack();
            add_group.Show();
            add_group.BringToFront();
            clear_textfield();
            add_group.Text = "Update Employee";
            update2.Hide();
            confirm_and_add.Hide();
            confirm_and_update.Show();
            confirm_and_update.BringToFront();
        }
        private void update_employee_group(object sender, EventArgs e)
        {
            String query = "Select * from employee where g_id = '" +g_id+ "' AND emp_id = '" +e_id.Text+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con_string);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (e_id.Text == "" || dtable.Rows.Count == 0)
            {
                clear_textfield();
                e_id_err.Text = "X";
                update2.Hide();
                return;
            }
            e_id_err.Text = "";
            String query2 = "Select * from employee where g_id = '" +g_id+ "' AND e_id = '" + e_id.Text + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
            DataTable dtable2 = new DataTable();
            sda.Fill(dtable2);
            DataRow[] g_rows = dtable.Select();
            fname.Text = g_rows[0]["fname"].ToString();
            lname.Text = g_rows[0]["lname"].ToString();
            designation.Text = g_rows[0]["desig"].ToString();
            cnum.Text = g_rows[0]["contact"].ToString();
            dstart.Text = g_rows[0]["duty_start"].ToString();
            dend.Text = g_rows[0]["duty_end"].ToString();
            sal.Text = g_rows[0]["salary"].ToString();
            update2.Show();
        }

        private void update_for_real(object sender, EventArgs e)
        {
            using (SqlConnection conn1 = new SqlConnection(con_string))
            {
                try
                {
                    double salary = double.Parse(sal.Text);
                    conn1.Open();
                    String query = "update employee set fname = '" + fname.Text + "', lname = '" + lname.Text + "', salary = '" + salary + "', desig = '" + designation.Text + "', contact = '" + cnum.Text + "', duty_start = '" + dstart.Text + "', duty_end = '" + dend.Text + "' where g_id = '" + g_id + "' and emp_id = '" + e_id.Text + "';";
                    cmd = new SqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Employee details updated succesfully");
                    button1.PerformClick();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input");
                }
              
            }
        }

        private void delete_employee(object sender, EventArgs e)
        {
            add_group.SendToBack();
            add_group.Hide();
            delete_raise_group.Show();
            delete_raise_group.BringToFront();
        }

        private void delete_employee_group(object sender, EventArgs e)
        {
            
            using (SqlConnection conn1 = new SqlConnection(con_string))
            {
                try
                {
                    conn1.Open();
                    String query = "delete from employee where g_id = '" + g_id + "' and emp_id = '" + delete_emp.Text + "';";
                    cmd = new SqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                    conn1.Close();
                    MessageBox.Show("Employee details deleted succesfully");
                    button1.PerformClick();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input");

                }
               
            }
        }

        private void update_salary(object sender, EventArgs e)
        {

        }
    }
}
