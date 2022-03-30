
namespace FMS
{
    partial class login_prompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.create_section = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.new_supplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pass_err = new System.Windows.Forms.Label();
            this.new_diesel_max_err = new System.Windows.Forms.Label();
            this.new_petrol_max_err = new System.Windows.Forms.Label();
            this.new_address_err = new System.Windows.Forms.Label();
            this.new_pin_err = new System.Windows.Forms.Label();
            this.new_g_id_err = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.new_confirm_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.l7 = new System.Windows.Forms.Label();
            this.new_state = new System.Windows.Forms.ComboBox();
            this.new_diesel_max = new System.Windows.Forms.TextBox();
            this.new_petrol_max = new System.Windows.Forms.TextBox();
            this.new_address = new System.Windows.Forms.TextBox();
            this.new_pin = new System.Windows.Forms.TextBox();
            this.new_g_id = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.new_admin_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.admin_err = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.g_login);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(242, 22);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(184, 22);
            this.username_text.TabIndex = 3;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(242, 63);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(184, 22);
            this.password_text.TabIndex = 4;
            // 
            // create_section
            // 
            this.create_section.AutoSize = true;
            this.create_section.ForeColor = System.Drawing.Color.MediumBlue;
            this.create_section.Location = new System.Drawing.Point(164, 155);
            this.create_section.Name = "create_section";
            this.create_section.Size = new System.Drawing.Size(133, 17);
            this.create_section.TabIndex = 5;
            this.create_section.Text = "Create new account";
            this.create_section.Click += new System.EventHandler(this.create_section_controls);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admin_err);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.new_admin_pass);
            this.groupBox1.Controls.Add(this.new_supplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.new_pass_err);
            this.groupBox1.Controls.Add(this.new_diesel_max_err);
            this.groupBox1.Controls.Add(this.new_petrol_max_err);
            this.groupBox1.Controls.Add(this.new_address_err);
            this.groupBox1.Controls.Add(this.new_pin_err);
            this.groupBox1.Controls.Add(this.new_g_id_err);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.new_confirm_pass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.new_pass);
            this.groupBox1.Controls.Add(this.l7);
            this.groupBox1.Controls.Add(this.new_state);
            this.groupBox1.Controls.Add(this.new_diesel_max);
            this.groupBox1.Controls.Add(this.new_petrol_max);
            this.groupBox1.Controls.Add(this.new_address);
            this.groupBox1.Controls.Add(this.new_pin);
            this.groupBox1.Controls.Add(this.new_g_id);
            this.groupBox1.Controls.Add(this.l6);
            this.groupBox1.Controls.Add(this.l5);
            this.groupBox1.Controls.Add(this.l4);
            this.groupBox1.Controls.Add(this.l3);
            this.groupBox1.Controls.Add(this.l2);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 452);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE ACCOUNT";
            // 
            // new_supplier
            // 
            this.new_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_supplier.FormattingEnabled = true;
            this.new_supplier.Items.AddRange(new object[] {
            "Indian Oil Corp",
            "Hindustan Petrol",
            "Essar Petroleum"});
            this.new_supplier.Location = new System.Drawing.Point(117, 246);
            this.new_supplier.Name = "new_supplier";
            this.new_supplier.Size = new System.Drawing.Size(174, 24);
            this.new_supplier.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Supplier";
            // 
            // new_pass_err
            // 
            this.new_pass_err.AutoSize = true;
            this.new_pass_err.ForeColor = System.Drawing.Color.Red;
            this.new_pass_err.Location = new System.Drawing.Point(322, 292);
            this.new_pass_err.Name = "new_pass_err";
            this.new_pass_err.Size = new System.Drawing.Size(0, 17);
            this.new_pass_err.TabIndex = 24;
            // 
            // new_diesel_max_err
            // 
            this.new_diesel_max_err.AutoSize = true;
            this.new_diesel_max_err.ForeColor = System.Drawing.Color.Red;
            this.new_diesel_max_err.Location = new System.Drawing.Point(322, 202);
            this.new_diesel_max_err.Name = "new_diesel_max_err";
            this.new_diesel_max_err.Size = new System.Drawing.Size(0, 17);
            this.new_diesel_max_err.TabIndex = 23;
            // 
            // new_petrol_max_err
            // 
            this.new_petrol_max_err.AutoSize = true;
            this.new_petrol_max_err.ForeColor = System.Drawing.Color.Red;
            this.new_petrol_max_err.Location = new System.Drawing.Point(322, 178);
            this.new_petrol_max_err.Name = "new_petrol_max_err";
            this.new_petrol_max_err.Size = new System.Drawing.Size(0, 17);
            this.new_petrol_max_err.TabIndex = 22;
            // 
            // new_address_err
            // 
            this.new_address_err.AutoSize = true;
            this.new_address_err.ForeColor = System.Drawing.Color.Red;
            this.new_address_err.Location = new System.Drawing.Point(319, 135);
            this.new_address_err.Name = "new_address_err";
            this.new_address_err.Size = new System.Drawing.Size(0, 17);
            this.new_address_err.TabIndex = 21;
            // 
            // new_pin_err
            // 
            this.new_pin_err.AutoSize = true;
            this.new_pin_err.ForeColor = System.Drawing.Color.Red;
            this.new_pin_err.Location = new System.Drawing.Point(319, 106);
            this.new_pin_err.Name = "new_pin_err";
            this.new_pin_err.Size = new System.Drawing.Size(0, 17);
            this.new_pin_err.TabIndex = 20;
            // 
            // new_g_id_err
            // 
            this.new_g_id_err.AutoSize = true;
            this.new_g_id_err.ForeColor = System.Drawing.Color.Red;
            this.new_g_id_err.Location = new System.Drawing.Point(319, 34);
            this.new_g_id_err.Name = "new_g_id_err";
            this.new_g_id_err.Size = new System.Drawing.Size(0, 17);
            this.new_g_id_err.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "ADD USER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.create_new_user);
            // 
            // new_confirm_pass
            // 
            this.new_confirm_pass.Location = new System.Drawing.Point(138, 315);
            this.new_confirm_pass.Name = "new_confirm_pass";
            this.new_confirm_pass.Size = new System.Drawing.Size(153, 22);
            this.new_confirm_pass.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password";
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(138, 287);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(153, 22);
            this.new_pass.TabIndex = 15;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(63, 292);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(69, 17);
            this.l7.TabIndex = 14;
            this.l7.Text = "Password";
            // 
            // new_state
            // 
            this.new_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_state.FormattingEnabled = true;
            this.new_state.Items.AddRange(new object[] {
            "Bihar",
            "Delhi",
            "Karnataka ",
            "Maharashtra",
            "Rajasthan",
            "Tamil Nadu",
            "Telangana"});
            this.new_state.Location = new System.Drawing.Point(117, 68);
            this.new_state.Name = "new_state";
            this.new_state.Size = new System.Drawing.Size(174, 24);
            this.new_state.TabIndex = 13;
            // 
            // new_diesel_max
            // 
            this.new_diesel_max.Location = new System.Drawing.Point(220, 202);
            this.new_diesel_max.Name = "new_diesel_max";
            this.new_diesel_max.Size = new System.Drawing.Size(71, 22);
            this.new_diesel_max.TabIndex = 12;
            // 
            // new_petrol_max
            // 
            this.new_petrol_max.Location = new System.Drawing.Point(220, 173);
            this.new_petrol_max.Name = "new_petrol_max";
            this.new_petrol_max.Size = new System.Drawing.Size(71, 22);
            this.new_petrol_max.TabIndex = 11;
            // 
            // new_address
            // 
            this.new_address.Location = new System.Drawing.Point(117, 135);
            this.new_address.Name = "new_address";
            this.new_address.Size = new System.Drawing.Size(174, 22);
            this.new_address.TabIndex = 10;
            // 
            // new_pin
            // 
            this.new_pin.Location = new System.Drawing.Point(117, 103);
            this.new_pin.Name = "new_pin";
            this.new_pin.Size = new System.Drawing.Size(174, 22);
            this.new_pin.TabIndex = 9;
            // 
            // new_g_id
            // 
            this.new_g_id.Location = new System.Drawing.Point(117, 34);
            this.new_g_id.Name = "new_g_id";
            this.new_g_id.Size = new System.Drawing.Size(174, 22);
            this.new_g_id.TabIndex = 7;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(16, 207);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(105, 17);
            this.l6.TabIndex = 5;
            this.l6.Text = "Diesel Capacity";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(18, 178);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(103, 17);
            this.l5.TabIndex = 4;
            this.l5.Text = "Petrol Capacity";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(51, 140);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(60, 17);
            this.l4.TabIndex = 3;
            this.l4.Text = "Address";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(72, 108);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(30, 17);
            this.l3.TabIndex = 2;
            this.l3.Text = "PIN";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(61, 75);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(41, 17);
            this.l2.TabIndex = 1;
            this.l2.Text = "State";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(29, 39);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(73, 17);
            this.l1.TabIndex = 0;
            this.l1.Text = "Username";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.login_exit_event);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FMS.Properties.Resources.gas_pump_logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // new_admin_pass
            // 
            this.new_admin_pass.Location = new System.Drawing.Point(138, 352);
            this.new_admin_pass.Name = "new_admin_pass";
            this.new_admin_pass.Size = new System.Drawing.Size(153, 22);
            this.new_admin_pass.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Admin Password";
            // 
            // admin_err
            // 
            this.admin_err.AutoSize = true;
            this.admin_err.ForeColor = System.Drawing.Color.Red;
            this.admin_err.Location = new System.Drawing.Point(322, 355);
            this.admin_err.Name = "admin_err";
            this.admin_err.Size = new System.Drawing.Size(0, 17);
            this.admin_err.TabIndex = 29;
            // 
            // login_prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.create_section);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login_prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMS Login";
            this.Load += new System.EventHandler(this.login_prompt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label create_section;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox new_state;
        private System.Windows.Forms.TextBox new_diesel_max;
        private System.Windows.Forms.TextBox new_petrol_max;
        private System.Windows.Forms.TextBox new_address;
        private System.Windows.Forms.TextBox new_pin;
        private System.Windows.Forms.TextBox new_g_id;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox new_confirm_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label new_g_id_err;
        private System.Windows.Forms.Label new_pass_err;
        private System.Windows.Forms.Label new_diesel_max_err;
        private System.Windows.Forms.Label new_petrol_max_err;
        private System.Windows.Forms.Label new_address_err;
        private System.Windows.Forms.Label new_pin_err;
        private System.Windows.Forms.ComboBox new_supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox new_admin_pass;
        private System.Windows.Forms.Label admin_err;
    }
}

