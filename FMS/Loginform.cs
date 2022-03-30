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
    public partial class login_prompt : Form
    {
        public string blank_error = "This field cannot be blank";
        public login_prompt()
        {
            InitializeComponent();
        }
        public string conn_string = @"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=1234567Aa";
        
        SqlCommand cmd;
        private void g_login(object sender, EventArgs e)
        {

            String g_username = username_text.Text;
            String g_password = password_text.Text;

            String g_state;
            String g_pin;
            String g_address;
            double g_petrol_max;
            double g_diesel_max;
            double g_petrol_curr;
            double g_diesel_curr;


            if (g_username != "" || g_password != "")
            {
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    try
                    {
                        String querry = "Select * from gas_station where g_id = '" + g_username + "' AND g_pass = '" + g_password + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);
                        DataRow[] g_rows = dtable.Select();
                        g_state = g_rows[0]["g_state"].ToString();
                        g_pin = g_rows[0]["g_pin"].ToString();
                        g_address = g_rows[0]["address"].ToString();
                        g_petrol_max = double.Parse(g_rows[0]["petrol_max"].ToString());
                        g_diesel_max = double.Parse(g_rows[0]["diesel_max"].ToString());
                        g_petrol_curr = double.Parse(g_rows[0]["petrol_curr"].ToString());
                        g_diesel_curr = double.Parse(g_rows[0]["diesel_curr"].ToString());

                        

                            if (dtable.Rows.Count > 0)
                        {

                            //MessageBox.Show();

                            Menuform form2 = new Menuform(g_username, g_address, g_state, g_pin, g_petrol_max, g_diesel_max, g_petrol_curr, g_diesel_curr);
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Password field is empty");
            }
        }

        private void login_prompt_Load(object sender, EventArgs e)
        {
            Size = new Size(400, 200);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            new_state.SelectedIndex = 0;
            new_supplier.SelectedIndex = 0;
            groupBox1.Hide();
        }

        private void login_exit_event(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void create_section_controls(object sender, EventArgs e)
        {
            Size = new Size(464, 553);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            groupBox1.Show();
        }
        public void clear_text()
        {
            new_g_id_err.Text = "";
            new_pin_err.Text = "";
            new_address_err.Text = "";
            new_petrol_max_err.Text = "";
            new_diesel_max_err.Text = "";
            new_pass_err.Text = "";
            admin_err.Text = "";
           
        }

        
        private bool allright()
        {
            clear_text();
            bool check = true;
            if(new_g_id.Text == "")
            {
                new_g_id_err.Text = blank_error;
                check = false;
            }
            if (new_pin.Text.Length != 6)
            {
                new_pin_err.Text = "Invalid pin code";
                check = false;
            }
            else
            {
                try
                {
                    int.Parse(new_pin.Text);
                }
                catch (Exception)
                {
                    new_pin_err.Text = "Invalid pin code";
                }
            }
            if (new_address.Text == "")
            {
                new_address_err.Text = blank_error;
                check = false;
            }
            if (new_petrol_max.Text == "" && new_diesel_max.Text == "")
            {
                new_petrol_max_err.Text = "Both capacity fields cannot be blank";
                check = false;
            }
            if(new_petrol_max.Text != "")
            {
                try
                {
                    double.Parse(new_petrol_max.Text);
                }
                catch(Exception)
                {
                    new_petrol_max_err.Text = "Not a valid input";
                    check = false;
                }
            }
            if (new_diesel_max.Text != "")
            {
                try
                {
                    double.Parse(new_diesel_max.Text);
                }
                catch (Exception)
                {
                    new_diesel_max_err.Text = "Not a valid input";
                    check = false;
                }
            }
            if(new_pass.Text == "" && new_confirm_pass.Text == "")
            {
                new_pass_err.Text = blank_error;
                check = false;
            }
            else
            {
                if (new_pass.Text != new_confirm_pass.Text)
                {
                    new_pass_err.Text = "Passwords not matching";
                    check = false;
                }
            }
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                try
                {
                    String querry = "Select g_pass from gas_station where g_id = '"+"admin"+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    DataRow[] g_rows = dtable.Select();
                    string admin_pass = g_rows[0]["g_pass"].ToString();
                    if (new_admin_pass.Text != admin_pass)
                    {
                        admin_err.Text = "Incorrect admin password";
                        check = false;
                    }
                           
                }
                catch (Exception)
                {
                    admin_err.Text = "Incorrect admin password";
                    check = false;
                }
                }
            return check;
        }
        private void create_new_user(object sender, EventArgs e)
        {
            double new_petrol_double;
            double new_diesel_double;
            clear_text();
            bool check = allright();
            if (!allright())
            {
                return;
            }
            if (new_petrol_max.Text != "")
                new_petrol_double = double.Parse(new_petrol_max.Text);
            else
                new_petrol_double = 0;

            if (new_diesel_max.Text != "")
                new_diesel_double = double.Parse(new_diesel_max.Text);
            else
                new_diesel_double = 0;
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                try
                {
                    conn.Open();
                    String query = "insert into gas_station values('" + new_g_id.Text + "','" + new_state.Text + "','" + new_pin.Text + "','" + new_supplier.Text + "','" + new_pass.Text + "','" + new_address.Text + "',0,0,'" + new_petrol_double + "','" + new_diesel_double + "',NULL,0);";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User created");
                    clear_text();
                }
                catch (Exception)
                {
                    new_g_id_err.Text = "Username already taken";
                }
            }
        }
    }
    }
