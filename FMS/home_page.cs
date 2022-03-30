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
    public partial class home_page : UserControl
    {
        static double petrol_price;
        static double diesel_price;

        public double home_g_pmax { get; set; }
        public double home_g_dmax { get; set; }
        public double home_g_pcurr { get; set; }
        public double home_g_dcurr { get; set; }
        public string home_g_id { get; set; }

        // check if number plate in database or not
        
        private bool check_in_vehicle_list(string number_plate)
        {
           
            String querry = "Select * from vehicle_details where number_plate = '" +number_plate + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            
            if (dtable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // check function ends here 

        // get cost in partiular state 
        public void get_current_prices()
        {
            String query = "select petrol_price, diesel_price from state_price, gas_station where state = g_state and g_id = '"+home_g_id+"';";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            DataRow[] g_rows = dtable.Select();
            petrol_price = double.Parse(g_rows[0]["petrol_price"].ToString());
            diesel_price = double.Parse(g_rows[0]["diesel_price"].ToString());
        }
        //  function ends here 
        
        // find vehicle type - petrol or diesel
        private string vehicle_type(string number_plate)
        {
            string v_type;
            String query = "select p_or_d from vehicle_details where number_plate = '"+number_plate+"';";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            DataRow[] type_rows = dtable.Select();
            v_type = type_rows[0]["p_or_d"].ToString();
            return v_type;
        }
        // function ends 

        //cost -> litres
        private double compute_volume(double cost, string v_type)
        {
            if (v_type == "P")
                return cost / petrol_price;
            else
                return cost / diesel_price;
        }
        // function ends here 

        //litres -> cost
        private double compute_cost(double litres, string v_type)
        {
            if (v_type == "P")
                return litres * petrol_price;
            else
                return litres * diesel_price;
        }
        //function ends here 


        //function to check if fuel available;
        private bool transfer_from_bunk_to_vehicle(double litres, string v_type)
        {

            String query = "select petrol_curr, diesel_curr from gas_station where g_id = '"+home_g_id+"';";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            DataRow[] avail = dtable.Select();
            double petrol_curr = double.Parse(avail[0]["petrol_curr"].ToString());
            double diesel_curr = double.Parse(avail[0]["diesel_curr"].ToString());

            if (litres > petrol_curr && v_type == "P")
                return false;

            else if (litres > diesel_curr && v_type == "D")
                return false;
            else
                return true;
        }
        //
        public home_page()
        {
            InitializeComponent();
          
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-27T565KJ\SQLEXPRESS;Initial Catalog=dbms_miniproject;Persist Security Info=True;User ID=root;Password=yourpassword");
        SqlCommand cmd;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            
            c_or_v_input.SelectedIndex = 1;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refill_event(object sender, EventArgs e)
        {
            get_current_prices();

            double cost, volume;
            string v_type;
            string curr_time = DateTime.Now.ToString("HH:mm:ss");
            string curr_date = DateTime.Now.ToString("yyyy-MM-dd");
            string register_number = register_number_input.Text;
            double value;
            try
            {
                 value = double.Parse(amount_input.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid input");
                return;
            }
          
            string c_or_v = c_or_v_input.Text;

            

           
            if (check_in_vehicle_list(register_number))
            {
                v_type = vehicle_type(register_number);
                if (c_or_v == "L")
                {
                    volume = value;
                    cost = compute_cost(value, v_type);
                }
                else
                {
                    cost = value;
                    volume = compute_volume(value, v_type);
                }

                if (transfer_from_bunk_to_vehicle(volume, v_type) == false)
                {
                    MessageBox.Show("Insufficient fuel in storage");
                    return;
                }
                try
                {
                    conn.Open();
                    String query = "insert into invoice values('" + home_g_id + "','" + volume + "','" + register_number + "','" + curr_time + "','" + cost + "','" + curr_date + "');";
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice Generated");
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No match found, Add vehicle from Register tab");
                }
             }


            else
            {
                MessageBox.Show("No match found, Add vehicle from Register tab");
            }
            button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String querry = "select petrol_curr, diesel_curr, petrol_price, diesel_price from state_price, gas_station where g_id = '" + home_g_id + "' and state_price.state = g_state;";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            DataRow[] g_rows = dtable.Select();
            prate.Text = g_rows[0]["petrol_price"].ToString();
            drate.Text = g_rows[0]["diesel_price"].ToString();
            pavail.Text = double.Parse(g_rows[0]["petrol_curr"].ToString()).ToString("F2");
            davail.Text = double.Parse(g_rows[0]["diesel_curr"].ToString()).ToString("F2");

        }
    }
}
