
namespace FMS
{
    partial class employee_page
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutystartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbms_miniprojectDataSetEmployee = new FMS.dbms_miniprojectDataSetEmployee();
            this.employeeTableAdapter = new FMS.dbms_miniprojectDataSetEmployeeTableAdapters.employeeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.curr_emp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.add_group = new System.Windows.Forms.GroupBox();
            this.sal_err = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sal = new System.Windows.Forms.TextBox();
            this.update2 = new System.Windows.Forms.Button();
            this.dend_err = new System.Windows.Forms.Label();
            this.dstart_err = new System.Windows.Forms.Label();
            this.cnum_err = new System.Windows.Forms.Label();
            this.lname_err = new System.Windows.Forms.Label();
            this.fname_err = new System.Windows.Forms.Label();
            this.e_id_err = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.ComboBox();
            this.dend = new System.Windows.Forms.TextBox();
            this.dstart = new System.Windows.Forms.TextBox();
            this.cnum = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.e_id = new System.Windows.Forms.TextBox();
            this.confirm_and_update = new System.Windows.Forms.Button();
            this.confirm_and_add = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.delete_raise_group = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.delete_emp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbms_miniprojectDataSetEmployee)).BeginInit();
            this.add_group.SuspendLayout();
            this.delete_raise_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.desigDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.dutystartDataGridViewTextBoxColumn,
            this.dutyendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.empidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            this.empidDataGridViewTextBoxColumn.Width = 50;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnameDataGridViewTextBoxColumn.Width = 64;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lnameDataGridViewTextBoxColumn.Width = 64;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 77;
            // 
            // desigDataGridViewTextBoxColumn
            // 
            this.desigDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.desigDataGridViewTextBoxColumn.DataPropertyName = "desig";
            this.desigDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.desigDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.desigDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desigDataGridViewTextBoxColumn.Name = "desigDataGridViewTextBoxColumn";
            this.desigDataGridViewTextBoxColumn.ReadOnly = true;
            this.desigDataGridViewTextBoxColumn.Width = 112;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.FillWeight = 385.0267F;
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact no";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 105;
            // 
            // dutystartDataGridViewTextBoxColumn
            // 
            this.dutystartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dutystartDataGridViewTextBoxColumn.DataPropertyName = "duty_start";
            this.dutystartDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.dutystartDataGridViewTextBoxColumn.HeaderText = "Duty Start";
            this.dutystartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dutystartDataGridViewTextBoxColumn.Name = "dutystartDataGridViewTextBoxColumn";
            this.dutystartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dutyendDataGridViewTextBoxColumn
            // 
            this.dutyendDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dutyendDataGridViewTextBoxColumn.DataPropertyName = "duty_end";
            this.dutyendDataGridViewTextBoxColumn.FillWeight = 59.28188F;
            this.dutyendDataGridViewTextBoxColumn.HeaderText = "Duty End";
            this.dutyendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dutyendDataGridViewTextBoxColumn.Name = "dutyendDataGridViewTextBoxColumn";
            this.dutyendDataGridViewTextBoxColumn.ReadOnly = true;
            this.dutyendDataGridViewTextBoxColumn.Width = 95;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.dbms_miniprojectDataSetEmployee;
            // 
            // dbms_miniprojectDataSetEmployee
            // 
            this.dbms_miniprojectDataSetEmployee.DataSetName = "dbms_miniprojectDataSetEmployee";
            this.dbms_miniprojectDataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retrieve/Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refresh_data);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Pump Attendant Incharge :";
            // 
            // curr_emp
            // 
            this.curr_emp.AutoSize = true;
            this.curr_emp.Location = new System.Drawing.Point(242, 229);
            this.curr_emp.Name = "curr_emp";
            this.curr_emp.Size = new System.Drawing.Size(0, 17);
            this.curr_emp.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_employee);
            // 
            // add_group
            // 
            this.add_group.Controls.Add(this.sal_err);
            this.add_group.Controls.Add(this.label10);
            this.add_group.Controls.Add(this.sal);
            this.add_group.Controls.Add(this.update2);
            this.add_group.Controls.Add(this.dend_err);
            this.add_group.Controls.Add(this.dstart_err);
            this.add_group.Controls.Add(this.cnum_err);
            this.add_group.Controls.Add(this.lname_err);
            this.add_group.Controls.Add(this.fname_err);
            this.add_group.Controls.Add(this.e_id_err);
            this.add_group.Controls.Add(this.label8);
            this.add_group.Controls.Add(this.label7);
            this.add_group.Controls.Add(this.label6);
            this.add_group.Controls.Add(this.label5);
            this.add_group.Controls.Add(this.label4);
            this.add_group.Controls.Add(this.label3);
            this.add_group.Controls.Add(this.label2);
            this.add_group.Controls.Add(this.designation);
            this.add_group.Controls.Add(this.dend);
            this.add_group.Controls.Add(this.dstart);
            this.add_group.Controls.Add(this.cnum);
            this.add_group.Controls.Add(this.lname);
            this.add_group.Controls.Add(this.fname);
            this.add_group.Controls.Add(this.e_id);
            this.add_group.Controls.Add(this.confirm_and_update);
            this.add_group.Controls.Add(this.confirm_and_add);
            this.add_group.Location = new System.Drawing.Point(3, 260);
            this.add_group.Name = "add_group";
            this.add_group.Size = new System.Drawing.Size(734, 230);
            this.add_group.TabIndex = 5;
            this.add_group.TabStop = false;
            this.add_group.Text = "ADD EMPLOYEE";
            // 
            // sal_err
            // 
            this.sal_err.AutoSize = true;
            this.sal_err.ForeColor = System.Drawing.Color.Red;
            this.sal_err.Location = new System.Drawing.Point(222, 205);
            this.sal_err.Name = "sal_err";
            this.sal_err.Size = new System.Drawing.Size(24, 17);
            this.sal_err.TabIndex = 24;
            this.sal_err.Text = "e1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Salary";
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(95, 202);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(121, 22);
            this.sal.TabIndex = 22;
            // 
            // update2
            // 
            this.update2.Location = new System.Drawing.Point(563, 160);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(84, 28);
            this.update2.TabIndex = 21;
            this.update2.Text = "Update";
            this.update2.UseVisualStyleBackColor = true;
            this.update2.Click += new System.EventHandler(this.update_for_real);
            // 
            // dend_err
            // 
            this.dend_err.AutoSize = true;
            this.dend_err.ForeColor = System.Drawing.Color.Red;
            this.dend_err.Location = new System.Drawing.Point(560, 122);
            this.dend_err.Name = "dend_err";
            this.dend_err.Size = new System.Drawing.Size(24, 17);
            this.dend_err.TabIndex = 19;
            this.dend_err.Text = "e1";
            // 
            // dstart_err
            // 
            this.dstart_err.AutoSize = true;
            this.dstart_err.ForeColor = System.Drawing.Color.Red;
            this.dstart_err.Location = new System.Drawing.Point(560, 85);
            this.dstart_err.Name = "dstart_err";
            this.dstart_err.Size = new System.Drawing.Size(24, 17);
            this.dstart_err.TabIndex = 18;
            this.dstart_err.Text = "e1";
            // 
            // cnum_err
            // 
            this.cnum_err.AutoSize = true;
            this.cnum_err.ForeColor = System.Drawing.Color.Red;
            this.cnum_err.Location = new System.Drawing.Point(560, 46);
            this.cnum_err.Name = "cnum_err";
            this.cnum_err.Size = new System.Drawing.Size(24, 17);
            this.cnum_err.TabIndex = 17;
            this.cnum_err.Text = "e1";
            // 
            // lname_err
            // 
            this.lname_err.AutoSize = true;
            this.lname_err.ForeColor = System.Drawing.Color.Red;
            this.lname_err.Location = new System.Drawing.Point(222, 125);
            this.lname_err.Name = "lname_err";
            this.lname_err.Size = new System.Drawing.Size(24, 17);
            this.lname_err.TabIndex = 16;
            this.lname_err.Text = "e1";
            // 
            // fname_err
            // 
            this.fname_err.AutoSize = true;
            this.fname_err.ForeColor = System.Drawing.Color.Red;
            this.fname_err.Location = new System.Drawing.Point(222, 83);
            this.fname_err.Name = "fname_err";
            this.fname_err.Size = new System.Drawing.Size(24, 17);
            this.fname_err.TabIndex = 15;
            this.fname_err.Text = "e1";
            // 
            // e_id_err
            // 
            this.e_id_err.AutoSize = true;
            this.e_id_err.ForeColor = System.Drawing.Color.Red;
            this.e_id_err.Location = new System.Drawing.Point(222, 39);
            this.e_id_err.Name = "e_id_err";
            this.e_id_err.Size = new System.Drawing.Size(24, 17);
            this.e_id_err.TabIndex = 14;
            this.e_id_err.Text = "e1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Duty End Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duty Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee ID";
            // 
            // designation
            // 
            this.designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designation.FormattingEnabled = true;
            this.designation.Items.AddRange(new object[] {
            "pump_attendant",
            "Manager"});
            this.designation.Location = new System.Drawing.Point(95, 163);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(121, 24);
            this.designation.TabIndex = 6;
            // 
            // dend
            // 
            this.dend.Location = new System.Drawing.Point(394, 122);
            this.dend.Name = "dend";
            this.dend.Size = new System.Drawing.Size(160, 22);
            this.dend.TabIndex = 5;
            // 
            // dstart
            // 
            this.dstart.Location = new System.Drawing.Point(394, 80);
            this.dstart.Name = "dstart";
            this.dstart.Size = new System.Drawing.Size(160, 22);
            this.dstart.TabIndex = 4;
            // 
            // cnum
            // 
            this.cnum.Location = new System.Drawing.Point(394, 41);
            this.cnum.Name = "cnum";
            this.cnum.Size = new System.Drawing.Size(160, 22);
            this.cnum.TabIndex = 3;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(95, 122);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(121, 22);
            this.lname.TabIndex = 2;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(95, 80);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(121, 22);
            this.fname.TabIndex = 1;
            // 
            // e_id
            // 
            this.e_id.Location = new System.Drawing.Point(95, 36);
            this.e_id.Name = "e_id";
            this.e_id.Size = new System.Drawing.Size(121, 22);
            this.e_id.TabIndex = 0;
            // 
            // confirm_and_update
            // 
            this.confirm_and_update.Location = new System.Drawing.Point(407, 159);
            this.confirm_and_update.Name = "confirm_and_update";
            this.confirm_and_update.Size = new System.Drawing.Size(147, 28);
            this.confirm_and_update.TabIndex = 20;
            this.confirm_and_update.Text = "Search Employee";
            this.confirm_and_update.UseVisualStyleBackColor = true;
            this.confirm_and_update.Click += new System.EventHandler(this.update_employee_group);
            // 
            // confirm_and_add
            // 
            this.confirm_and_add.Location = new System.Drawing.Point(464, 160);
            this.confirm_and_add.Name = "confirm_and_add";
            this.confirm_and_add.Size = new System.Drawing.Size(90, 28);
            this.confirm_and_add.TabIndex = 7;
            this.confirm_and_add.Text = "Confirm";
            this.confirm_and_add.UseVisualStyleBackColor = true;
            this.confirm_and_add.Click += new System.EventHandler(this.add_employee_group);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.update_employee);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete Employee";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.delete_employee);
            // 
            // delete_raise_group
            // 
            this.delete_raise_group.Controls.Add(this.button5);
            this.delete_raise_group.Controls.Add(this.label9);
            this.delete_raise_group.Controls.Add(this.delete_emp);
            this.delete_raise_group.Location = new System.Drawing.Point(3, 260);
            this.delete_raise_group.Name = "delete_raise_group";
            this.delete_raise_group.Size = new System.Drawing.Size(750, 239);
            this.delete_raise_group.TabIndex = 22;
            this.delete_raise_group.TabStop = false;
            this.delete_raise_group.Text = "Delete Employee";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 2;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.delete_employee_group);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Employee ID";
            // 
            // delete_emp
            // 
            this.delete_emp.Location = new System.Drawing.Point(99, 33);
            this.delete_emp.Name = "delete_emp";
            this.delete_emp.Size = new System.Drawing.Size(160, 22);
            this.delete_emp.TabIndex = 0;
            // 
            // employee_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.curr_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_raise_group);
            this.Controls.Add(this.add_group);
            this.Name = "employee_page";
            this.Size = new System.Drawing.Size(776, 605);
            this.Load += new System.EventHandler(this.employee_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbms_miniprojectDataSetEmployee)).EndInit();
            this.add_group.ResumeLayout(false);
            this.add_group.PerformLayout();
            this.delete_raise_group.ResumeLayout(false);
            this.delete_raise_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private dbms_miniprojectDataSetEmployee dbms_miniprojectDataSetEmployee;
        private dbms_miniprojectDataSetEmployeeTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutystartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyendDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label curr_emp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox add_group;
        private System.Windows.Forms.Button confirm_and_add;
        private System.Windows.Forms.Label dend_err;
        private System.Windows.Forms.Label dstart_err;
        private System.Windows.Forms.Label cnum_err;
        private System.Windows.Forms.Label lname_err;
        private System.Windows.Forms.Label fname_err;
        private System.Windows.Forms.Label e_id_err;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox designation;
        private System.Windows.Forms.TextBox dend;
        private System.Windows.Forms.TextBox dstart;
        private System.Windows.Forms.TextBox cnum;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox e_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button confirm_and_update;
        private System.Windows.Forms.Button update2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox delete_raise_group;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox delete_emp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.Label sal_err;
    }
}
