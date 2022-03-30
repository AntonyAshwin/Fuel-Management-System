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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void Adminform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbms_miniprojectAdminData.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dbms_miniprojectAdminData.employee);

        }
    }
}
