
namespace YourCommunityWorkshop
{
    partial class frmEditCustomers
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnCloseCustomers = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(754, 462);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvCustomers_DoubleClick);
            // 
            // btnCloseCustomers
            // 
            this.btnCloseCustomers.Location = new System.Drawing.Point(670, 485);
            this.btnCloseCustomers.Name = "btnCloseCustomers";
            this.btnCloseCustomers.Size = new System.Drawing.Size(96, 39);
            this.btnCloseCustomers.TabIndex = 5;
            this.btnCloseCustomers.Text = "Close";
            this.btnCloseCustomers.UseVisualStyleBackColor = true;
            this.btnCloseCustomers.Click += new System.EventHandler(this.btnCloseCustomers_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Location = new System.Drawing.Point(297, 486);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(99, 36);
            this.btnDeleteCust.TabIndex = 3;
            this.btnDeleteCust.Text = "Delete";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(402, 486);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(99, 36);
            this.btnAddCust.TabIndex = 4;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchCustomer.Location = new System.Drawing.Point(12, 490);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(75, 25);
            this.lblSearchCustomer.TabIndex = 10;
            this.lblSearchCustomer.Text = "Search";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(93, 494);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(185, 22);
            this.txtSearchCustomer.TabIndex = 2;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(522, 480);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 44);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmEditCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 528);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnCloseCustomers);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditCustomers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCloseCustomers;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnReport;
    }
}