using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMS
{
    public partial class Menuform : Form
    {
        public Menuform(string g_id, string g_address, string g_state, string g_pin, double g_petrol_max, double g_diesel_max, double g_petrol_curr, double g_diesel_curr)
        {
            InitializeComponent();
            this.G_id = g_id;
            this.G_address = g_address;
            this.G_pin = g_pin;
            this.G_state = g_state;
            this.G_petrol_max = g_petrol_max;
            this.G_diesel_max = g_diesel_max;
            this.G_petrol_curr = g_petrol_curr;
            this.G_diesel_curr = g_diesel_curr;
        }
        public string G_id { get; set; }
        public string G_address { get; set; }
        public string G_pin { get; set; }
        public string G_state { get; set; }
        public double G_petrol_max { get; set; }
        public double G_diesel_max { get; set; }
        public double G_petrol_curr { get; set; }
        public double G_diesel_curr { get; set; }
        private void Menuform_Load(object sender, EventArgs e)
        {
            g_id.Text = G_id.ToUpper();
            address_label.Text = G_address;
            state_and_pin_label.Text = G_state + " - " + G_pin;
            home_page1.home_g_id = G_id;
            home_page1.home_g_pmax = G_petrol_max;
            home_page1.home_g_dmax = G_diesel_max;
            home_page1.home_g_pcurr = G_petrol_curr;
            home_page1.home_g_dcurr = G_diesel_curr;
            employee_page1.g_id = G_id;
            supplier_page1.g_id = G_id;
            options_page1.g_curr_petrol = G_petrol_curr;
            options_page1.g_curr_diesel = G_diesel_curr;
            invoice_page1.g_id = G_id;
            options_page1.g_id = G_id;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("h:mm:ss tt");
            day_label.Text = DateTime.Today.DayOfWeek.ToString();
            date_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void logout_event(object sender, EventArgs e)
        {
            this.Close();
            login_prompt form1 = new login_prompt();
            form1.Show();
        }

        private void exit_event(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void register_page1_Load(object sender, EventArgs e)
        {

        }

        private void home_event(object sender, EventArgs e)
        {
            home_page1.BringToFront();
        }

        private void register_event(object sender, EventArgs e)
        {
            register_page1.BringToFront();
        }

        private void employee__event(object sender, EventArgs e)
        {
            employee_page1.BringToFront();
        }

        private void home_page1_Load(object sender, EventArgs e)
        {

        }

        private void employee_page1_Load(object sender, EventArgs e)
        {

        }

        private void supplier_event(object sender, EventArgs e)
        {
            supplier_page1.BringToFront();
        }

        private void invoice_history_event(object sender, EventArgs e)
        {
            invoice_page1.BringToFront();
        }

        private void options_event(object sender, EventArgs e)
        {
            options_page1.BringToFront();
        }
    }
}
