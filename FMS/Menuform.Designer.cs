
namespace FMS
{
    partial class Menuform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.state_and_pin_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.g_id = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.options_button = new System.Windows.Forms.Button();
            this.invoice_button = new System.Windows.Forms.Button();
            this.supplier_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.home_page1 = new FMS.home_page();
            this.register_page1 = new FMS.register_page();
            this.employee_page1 = new FMS.employee_page();
            this.supplier_page1 = new FMS.supplier_page();
            this.invoice_page1 = new FMS.invoice_page();
            this.options_page1 = new FMS.options_page();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.state_and_pin_label);
            this.groupBox1.Controls.Add(this.address_label);
            this.groupBox1.Controls.Add(this.date_label);
            this.groupBox1.Controls.Add(this.day_label);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.g_id);
            this.groupBox1.Location = new System.Drawing.Point(275, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(843, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // state_and_pin_label
            // 
            this.state_and_pin_label.AutoSize = true;
            this.state_and_pin_label.Location = new System.Drawing.Point(9, 78);
            this.state_and_pin_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.state_and_pin_label.Name = "state_and_pin_label";
            this.state_and_pin_label.Size = new System.Drawing.Size(41, 17);
            this.state_and_pin_label.TabIndex = 7;
            this.state_and_pin_label.Text = "State";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(9, 48);
            this.address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "Address";
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(728, 48);
            this.date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(38, 17);
            this.date_label.TabIndex = 5;
            this.date_label.Text = "Date";
            // 
            // day_label
            // 
            this.day_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.day_label.AutoSize = true;
            this.day_label.Location = new System.Drawing.Point(728, 78);
            this.day_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(33, 17);
            this.day_label.TabIndex = 4;
            this.day_label.Text = "Day";
            // 
            // time_label
            // 
            this.time_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(728, 18);
            this.time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(39, 17);
            this.time_label.TabIndex = 3;
            this.time_label.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gas Station ID :";
            // 
            // g_id
            // 
            this.g_id.AutoSize = true;
            this.g_id.Location = new System.Drawing.Point(117, 18);
            this.g_id.Name = "g_id";
            this.g_id.Size = new System.Drawing.Size(35, 17);
            this.g_id.TabIndex = 2;
            this.g_id.Text = "g_id";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.exit_button);
            this.groupBox2.Controls.Add(this.logout_button);
            this.groupBox2.Controls.Add(this.options_button);
            this.groupBox2.Controls.Add(this.invoice_button);
            this.groupBox2.Controls.Add(this.supplier_button);
            this.groupBox2.Controls.Add(this.employee_button);
            this.groupBox2.Controls.Add(this.register_button);
            this.groupBox2.Controls.Add(this.home_button);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(252, 620);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FMS.Properties.Resources.gas_pump_logo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exit_button.Location = new System.Drawing.Point(127, 560);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(117, 28);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_event);
            // 
            // logout_button
            // 
            this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout_button.Location = new System.Drawing.Point(8, 560);
            this.logout_button.Margin = new System.Windows.Forms.Padding(4);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(111, 28);
            this.logout_button.TabIndex = 6;
            this.logout_button.Text = "Log out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_event);
            // 
            // options_button
            // 
            this.options_button.Location = new System.Drawing.Point(59, 408);
            this.options_button.Margin = new System.Windows.Forms.Padding(4);
            this.options_button.Name = "options_button";
            this.options_button.Size = new System.Drawing.Size(135, 28);
            this.options_button.TabIndex = 5;
            this.options_button.Text = "Options";
            this.options_button.UseVisualStyleBackColor = true;
            this.options_button.Click += new System.EventHandler(this.options_event);
            // 
            // invoice_button
            // 
            this.invoice_button.Location = new System.Drawing.Point(59, 357);
            this.invoice_button.Margin = new System.Windows.Forms.Padding(4);
            this.invoice_button.Name = "invoice_button";
            this.invoice_button.Size = new System.Drawing.Size(135, 28);
            this.invoice_button.TabIndex = 4;
            this.invoice_button.Text = "Invoice History";
            this.invoice_button.UseVisualStyleBackColor = true;
            this.invoice_button.Click += new System.EventHandler(this.invoice_history_event);
            // 
            // supplier_button
            // 
            this.supplier_button.Location = new System.Drawing.Point(59, 308);
            this.supplier_button.Margin = new System.Windows.Forms.Padding(4);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Size = new System.Drawing.Size(135, 28);
            this.supplier_button.TabIndex = 3;
            this.supplier_button.Text = "Supplier";
            this.supplier_button.UseVisualStyleBackColor = true;
            this.supplier_button.Click += new System.EventHandler(this.supplier_event);
            // 
            // employee_button
            // 
            this.employee_button.Location = new System.Drawing.Point(59, 261);
            this.employee_button.Margin = new System.Windows.Forms.Padding(4);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(135, 28);
            this.employee_button.TabIndex = 2;
            this.employee_button.Text = "Employees";
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee__event);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(59, 209);
            this.register_button.Margin = new System.Windows.Forms.Padding(4);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(135, 28);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register Vehicle";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_event);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(59, 163);
            this.home_button.Margin = new System.Windows.Forms.Padding(4);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(135, 28);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_event);
            // 
            // home_page1
            // 
            this.home_page1.home_g_dcurr = 0D;
            this.home_page1.home_g_dmax = 0D;
            this.home_page1.home_g_id = null;
            this.home_page1.home_g_pcurr = 0D;
            this.home_page1.home_g_pmax = 0D;
            this.home_page1.Location = new System.Drawing.Point(287, 125);
            this.home_page1.Name = "home_page1";
            this.home_page1.Size = new System.Drawing.Size(833, 507);
            this.home_page1.TabIndex = 3;
            this.home_page1.Load += new System.EventHandler(this.home_page1_Load);
            // 
            // register_page1
            // 
            this.register_page1.Location = new System.Drawing.Point(287, 125);
            this.register_page1.Name = "register_page1";
            this.register_page1.Size = new System.Drawing.Size(833, 507);
            this.register_page1.TabIndex = 4;
            // 
            // employee_page1
            // 
            this.employee_page1.g_id = null;
            this.employee_page1.Location = new System.Drawing.Point(287, 125);
            this.employee_page1.Name = "employee_page1";
            this.employee_page1.Size = new System.Drawing.Size(833, 507);
            this.employee_page1.TabIndex = 5;
            this.employee_page1.Load += new System.EventHandler(this.employee_page1_Load);
            // 
            // supplier_page1
            // 
            this.supplier_page1.g_id = null;
            this.supplier_page1.Location = new System.Drawing.Point(287, 125);
            this.supplier_page1.Name = "supplier_page1";
            this.supplier_page1.Size = new System.Drawing.Size(833, 507);
            this.supplier_page1.TabIndex = 6;
            // 
            // invoice_page1
            // 
            this.invoice_page1.g_id = null;
            this.invoice_page1.Location = new System.Drawing.Point(287, 125);
            this.invoice_page1.Name = "invoice_page1";
            this.invoice_page1.Size = new System.Drawing.Size(833, 507);
            this.invoice_page1.TabIndex = 7;
            // 
            // options_page1
            // 
            this.options_page1.g_id = null;
            this.options_page1.Location = new System.Drawing.Point(287, 125);
            this.options_page1.Name = "options_page1";
            this.options_page1.Size = new System.Drawing.Size(833, 507);
            this.options_page1.TabIndex = 8;
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.home_page1);
            this.Controls.Add(this.register_page1);
            this.Controls.Add(this.employee_page1);
            this.Controls.Add(this.supplier_page1);
            this.Controls.Add(this.invoice_page1);
            this.Controls.Add(this.options_page1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menuform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Management System";
            this.Load += new System.EventHandler(this.Menuform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label g_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button supplier_button;
        private System.Windows.Forms.Button employee_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button options_button;
        private System.Windows.Forms.Button invoice_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label state_and_pin_label;
        private System.Windows.Forms.Label address_label;
        private home_page home_page1;
        private register_page register_page1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private employee_page employee_page1;
        private supplier_page supplier_page1;
        private invoice_page invoice_page1;
        private options_page options_page1;
    }
}