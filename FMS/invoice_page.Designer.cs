
namespace FMS
{
    partial class invoice_page
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbms_miniprojectDataSetInvoice = new FMS.dbms_miniprojectDataSetInvoice();
            this.invoiceTableAdapter = new FMS.dbms_miniprojectDataSetInvoiceTableAdapters.invoiceTableAdapter();
            this.invoice_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.invoiceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbms_miniprojectDataSetInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Retrieve/Refresh All Invoices ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.retrieve_refresh);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceidDataGridViewTextBoxColumn,
            this.numberplateDataGridViewTextBoxColumn,
            this.fuelamountDataGridViewTextBoxColumn,
            this.purchaseamtDataGridViewTextBoxColumn,
            this.invoicetimeDataGridViewTextBoxColumn,
            this.invoicedateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.dbms_miniprojectDataSetInvoice;
            // 
            // dbms_miniprojectDataSetInvoice
            // 
            this.dbms_miniprojectDataSetInvoice.DataSetName = "dbms_miniprojectDataSetInvoice";
            this.dbms_miniprojectDataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoice_id
            // 
            this.invoice_id.Location = new System.Drawing.Point(144, 32);
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.Size = new System.Drawing.Size(189, 22);
            this.invoice_id.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Find through Invoice ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.find_invoice_id);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Find through Registration Number";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.find_rnumber);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(592, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Find through License Number";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.find_lnumber);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(144, 12);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(176, 17);
            this.warning.TabIndex = 9;
            this.warning.Text = "Invoice ID/R no/License no";
            // 
            // invoiceidDataGridViewTextBoxColumn
            // 
            this.invoiceidDataGridViewTextBoxColumn.DataPropertyName = "invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.HeaderText = "Invoice ID";
            this.invoiceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceidDataGridViewTextBoxColumn.Name = "invoiceidDataGridViewTextBoxColumn";
            this.invoiceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberplateDataGridViewTextBoxColumn
            // 
            this.numberplateDataGridViewTextBoxColumn.DataPropertyName = "number_plate";
            this.numberplateDataGridViewTextBoxColumn.HeaderText = "Number Plate";
            this.numberplateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberplateDataGridViewTextBoxColumn.Name = "numberplateDataGridViewTextBoxColumn";
            this.numberplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelamountDataGridViewTextBoxColumn
            // 
            this.fuelamountDataGridViewTextBoxColumn.DataPropertyName = "fuel_amount";
            this.fuelamountDataGridViewTextBoxColumn.HeaderText = "Fuel Volume (L)";
            this.fuelamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelamountDataGridViewTextBoxColumn.Name = "fuelamountDataGridViewTextBoxColumn";
            this.fuelamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseamtDataGridViewTextBoxColumn
            // 
            this.purchaseamtDataGridViewTextBoxColumn.DataPropertyName = "purchase_amt";
            this.purchaseamtDataGridViewTextBoxColumn.HeaderText = "Cost (₹)";
            this.purchaseamtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseamtDataGridViewTextBoxColumn.Name = "purchaseamtDataGridViewTextBoxColumn";
            this.purchaseamtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicetimeDataGridViewTextBoxColumn
            // 
            this.invoicetimeDataGridViewTextBoxColumn.DataPropertyName = "invoice_time";
            this.invoicetimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.invoicetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoicetimeDataGridViewTextBoxColumn.Name = "invoicetimeDataGridViewTextBoxColumn";
            this.invoicetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicedateDataGridViewTextBoxColumn
            // 
            this.invoicedateDataGridViewTextBoxColumn.DataPropertyName = "invoice_date";
            this.invoicedateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.invoicedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoicedateDataGridViewTextBoxColumn.Name = "invoicedateDataGridViewTextBoxColumn";
            this.invoicedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoice_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warning);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.invoice_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "invoice_page";
            this.Size = new System.Drawing.Size(756, 605);
            this.Load += new System.EventHandler(this.invoice_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbms_miniprojectDataSetInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private dbms_miniprojectDataSetInvoice dbms_miniprojectDataSetInvoice;
        private dbms_miniprojectDataSetInvoiceTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.TextBox invoice_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicedateDataGridViewTextBoxColumn;
    }
}
