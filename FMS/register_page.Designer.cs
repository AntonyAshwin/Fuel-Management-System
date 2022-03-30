
namespace FMS
{
    partial class register_page
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
            this.dbms_miniprojectDataSet = new FMS.dbms_miniprojectDataSet();
            this.vehicledetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicle_detailsTableAdapter = new FMS.dbms_miniprojectDataSetTableAdapters.vehicle_detailsTableAdapter();
            this.l_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_number = new System.Windows.Forms.TextBox();
            this.v_class = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.f_type = new System.Windows.Forms.ComboBox();
            this.add_vehicle = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.r_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbms_miniprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicledetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbms_miniprojectDataSet
            // 
            this.dbms_miniprojectDataSet.DataSetName = "dbms_miniprojectDataSet";
            this.dbms_miniprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicledetailsBindingSource
            // 
            this.vehicledetailsBindingSource.DataMember = "vehicle_details";
            this.vehicledetailsBindingSource.DataSource = this.dbms_miniprojectDataSet;
            // 
            // vehicle_detailsTableAdapter
            // 
            this.vehicle_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // l_number
            // 
            this.l_number.Location = new System.Drawing.Point(178, 21);
            this.l_number.Name = "l_number";
            this.l_number.Size = new System.Drawing.Size(171, 22);
            this.l_number.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "License Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registration Number";
            // 
            // r_number
            // 
            this.r_number.Location = new System.Drawing.Point(178, 59);
            this.r_number.Name = "r_number";
            this.r_number.Size = new System.Drawing.Size(171, 22);
            this.r_number.TabIndex = 3;
            // 
            // v_class
            // 
            this.v_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_class.FormattingEnabled = true;
            this.v_class.Items.AddRange(new object[] {
            "MCWG",
            "LMV",
            "FVG",
            "HPMV",
            "HGMV"});
            this.v_class.Location = new System.Drawing.Point(178, 99);
            this.v_class.Name = "v_class";
            this.v_class.Size = new System.Drawing.Size(121, 24);
            this.v_class.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fuel Type";
            // 
            // f_type
            // 
            this.f_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f_type.FormattingEnabled = true;
            this.f_type.Items.AddRange(new object[] {
            "P",
            "D"});
            this.f_type.Location = new System.Drawing.Point(178, 141);
            this.f_type.Name = "f_type";
            this.f_type.Size = new System.Drawing.Size(49, 24);
            this.f_type.TabIndex = 7;
            // 
            // add_vehicle
            // 
            this.add_vehicle.Location = new System.Drawing.Point(178, 187);
            this.add_vehicle.Name = "add_vehicle";
            this.add_vehicle.Size = new System.Drawing.Size(98, 35);
            this.add_vehicle.TabIndex = 8;
            this.add_vehicle.Text = "Register";
            this.add_vehicle.UseVisualStyleBackColor = true;
            this.add_vehicle.Click += new System.EventHandler(this.register_vehicle);
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.BackColor = System.Drawing.Color.Transparent;
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(355, 21);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 17);
            this.l_error.TabIndex = 9;
            // 
            // r_error
            // 
            this.r_error.AutoSize = true;
            this.r_error.BackColor = System.Drawing.Color.Transparent;
            this.r_error.ForeColor = System.Drawing.Color.Red;
            this.r_error.Location = new System.Drawing.Point(355, 62);
            this.r_error.Name = "r_error";
            this.r_error.Size = new System.Drawing.Size(0, 17);
            this.r_error.TabIndex = 10;
            // 
            // register_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.r_error);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.add_vehicle);
            this.Controls.Add(this.f_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v_class);
            this.Controls.Add(this.r_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_number);
            this.Name = "register_page";
            this.Size = new System.Drawing.Size(756, 605);
            this.Load += new System.EventHandler(this.register_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbms_miniprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicledetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vehicledetailsBindingSource;
        private dbms_miniprojectDataSet dbms_miniprojectDataSet;
        private dbms_miniprojectDataSetTableAdapters.vehicle_detailsTableAdapter vehicle_detailsTableAdapter;
        private System.Windows.Forms.TextBox l_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_number;
        private System.Windows.Forms.ComboBox v_class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox f_type;
        private System.Windows.Forms.Button add_vehicle;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Label r_error;
    }
}
