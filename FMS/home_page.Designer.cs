
namespace FMS
{
    partial class home_page
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
            this.register_number_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.c_or_v_input = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.drate = new System.Windows.Forms.Label();
            this.prate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pavail = new System.Windows.Forms.Label();
            this.davail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_number_input
            // 
            this.register_number_input.Location = new System.Drawing.Point(182, 27);
            this.register_number_input.Name = "register_number_input";
            this.register_number_input.Size = new System.Drawing.Size(161, 22);
            this.register_number_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // amount_input
            // 
            this.amount_input.Location = new System.Drawing.Point(182, 70);
            this.amount_input.Name = "amount_input";
            this.amount_input.Size = new System.Drawing.Size(161, 22);
            this.amount_input.TabIndex = 3;
            this.amount_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // c_or_v_input
            // 
            this.c_or_v_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_or_v_input.FormattingEnabled = true;
            this.c_or_v_input.Items.AddRange(new object[] {
            "₹ ",
            "L"});
            this.c_or_v_input.Location = new System.Drawing.Point(349, 70);
            this.c_or_v_input.Name = "c_or_v_input";
            this.c_or_v_input.Size = new System.Drawing.Size(44, 24);
            this.c_or_v_input.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refill_event);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.davail);
            this.groupBox1.Controls.Add(this.pavail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.drate);
            this.groupBox1.Controls.Add(this.prate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(26, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Rates";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh Rates";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drate
            // 
            this.drate.AutoSize = true;
            this.drate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drate.Location = new System.Drawing.Point(272, 47);
            this.drate.Name = "drate";
            this.drate.Size = new System.Drawing.Size(0, 36);
            this.drate.TabIndex = 5;
            // 
            // prate
            // 
            this.prate.AutoSize = true;
            this.prate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prate.Location = new System.Drawing.Point(57, 47);
            this.prate.Name = "prate";
            this.prate.Size = new System.Drawing.Size(0, 36);
            this.prate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Petrol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diesel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Petrol Available";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Diesel Available";
            // 
            // pavail
            // 
            this.pavail.AutoSize = true;
            this.pavail.Location = new System.Drawing.Point(118, 125);
            this.pavail.Name = "pavail";
            this.pavail.Size = new System.Drawing.Size(0, 17);
            this.pavail.TabIndex = 9;
            // 
            // davail
            // 
            this.davail.AutoSize = true;
            this.davail.Location = new System.Drawing.Point(333, 125);
            this.davail.Name = "davail";
            this.davail.Size = new System.Drawing.Size(0, 17);
            this.davail.TabIndex = 10;
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_or_v_input);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_number_input);
            this.Name = "home_page";
            this.Size = new System.Drawing.Size(756, 605);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox register_number_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.ComboBox c_or_v_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label drate;
        private System.Windows.Forms.Label prate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label davail;
        private System.Windows.Forms.Label pavail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
