
namespace YourCommunityWorkshop
{
    partial class frmRentals
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
            this.btnRent = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCloseRentals = new System.Windows.Forms.Button();
            this.lblFilterSearch = new System.Windows.Forms.Label();
            this.rbHired = new System.Windows.Forms.RadioButton();
            this.rbUnhired = new System.Windows.Forms.RadioButton();
            this.lblSearchByToolBrand = new System.Windows.Forms.Label();
            this.lblSearchByToolName = new System.Windows.Forms.Label();
            this.txtSearchToolBrand = new System.Windows.Forms.TextBox();
            this.txtSearchToolName = new System.Windows.Forms.TextBox();
            this.btnRentalReport = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtDateTimeReturned = new System.Windows.Forms.TextBox();
            this.txtDateTimeRented = new System.Windows.Forms.TextBox();
            this.lblDateTimeReturned = new System.Windows.Forms.Label();
            this.lblDateTimeRented = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cbToolCondition = new System.Windows.Forms.ComboBox();
            this.txtSelectToolName = new System.Windows.Forms.TextBox();
            this.txtSelectToolID = new System.Windows.Forms.TextBox();
            this.lblSelectedToolName = new System.Windows.Forms.Label();
            this.lblSelectedToolID = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lblRentSurname = new System.Windows.Forms.Label();
            this.lblRentName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbToolStatus = new System.Windows.Forms.ComboBox();
            this.lblToolStatus = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.btnToolsReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(1073, 629);
            this.btnRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(107, 34);
            this.btnRent.TabIndex = 12;
            this.btnRent.Text = "Rent Tool";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(12, 12);
            this.dgvRentals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 24;
            this.dgvRentals.Size = new System.Drawing.Size(764, 751);
            this.dgvRentals.TabIndex = 1;
            this.dgvRentals.DoubleClick += new System.EventHandler(this.dgvRentals_DoubleClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1073, 681);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(107, 33);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return Tool";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCloseRentals
            // 
            this.btnCloseRentals.Location = new System.Drawing.Point(1073, 731);
            this.btnCloseRentals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseRentals.Name = "btnCloseRentals";
            this.btnCloseRentals.Size = new System.Drawing.Size(111, 32);
            this.btnCloseRentals.TabIndex = 14;
            this.btnCloseRentals.Text = "Close";
            this.btnCloseRentals.UseVisualStyleBackColor = true;
            this.btnCloseRentals.Click += new System.EventHandler(this.btnCloseRentals_Click);
            // 
            // lblFilterSearch
            // 
            this.lblFilterSearch.AutoSize = true;
            this.lblFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilterSearch.Location = new System.Drawing.Point(781, 463);
            this.lblFilterSearch.Name = "lblFilterSearch";
            this.lblFilterSearch.Size = new System.Drawing.Size(105, 20);
            this.lblFilterSearch.TabIndex = 10;
            this.lblFilterSearch.Text = "Filter/Search";
            // 
            // rbHired
            // 
            this.rbHired.AutoSize = true;
            this.rbHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbHired.Location = new System.Drawing.Point(923, 593);
            this.rbHired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbHired.Name = "rbHired";
            this.rbHired.Size = new System.Drawing.Size(106, 22);
            this.rbHired.TabIndex = 7;
            this.rbHired.Text = "Hired Tools";
            this.rbHired.UseVisualStyleBackColor = true;
            this.rbHired.Click += new System.EventHandler(this.rbHired_Click);
            // 
            // rbUnhired
            // 
            this.rbUnhired.AutoSize = true;
            this.rbUnhired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbUnhired.Location = new System.Drawing.Point(1062, 593);
            this.rbUnhired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbUnhired.Name = "rbUnhired";
            this.rbUnhired.Size = new System.Drawing.Size(122, 22);
            this.rbUnhired.TabIndex = 8;
            this.rbUnhired.Text = "Unhired Tools";
            this.rbUnhired.UseVisualStyleBackColor = true;
            this.rbUnhired.Click += new System.EventHandler(this.rbUnhired_Click);
            // 
            // lblSearchByToolBrand
            // 
            this.lblSearchByToolBrand.AutoSize = true;
            this.lblSearchByToolBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchByToolBrand.Location = new System.Drawing.Point(781, 501);
            this.lblSearchByToolBrand.Name = "lblSearchByToolBrand";
            this.lblSearchByToolBrand.Size = new System.Drawing.Size(121, 20);
            this.lblSearchByToolBrand.TabIndex = 13;
            this.lblSearchByToolBrand.Text = "By Tool Brand:";
            // 
            // lblSearchByToolName
            // 
            this.lblSearchByToolName.AutoSize = true;
            this.lblSearchByToolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchByToolName.Location = new System.Drawing.Point(781, 544);
            this.lblSearchByToolName.Name = "lblSearchByToolName";
            this.lblSearchByToolName.Size = new System.Drawing.Size(120, 20);
            this.lblSearchByToolName.TabIndex = 14;
            this.lblSearchByToolName.Text = "By Tool Name:";
            // 
            // txtSearchToolBrand
            // 
            this.txtSearchToolBrand.Location = new System.Drawing.Point(979, 501);
            this.txtSearchToolBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchToolBrand.Name = "txtSearchToolBrand";
            this.txtSearchToolBrand.Size = new System.Drawing.Size(143, 22);
            this.txtSearchToolBrand.TabIndex = 4;
            this.txtSearchToolBrand.TextChanged += new System.EventHandler(this.txtSearchToolBrand_TextChanged);
            // 
            // txtSearchToolName
            // 
            this.txtSearchToolName.Location = new System.Drawing.Point(979, 544);
            this.txtSearchToolName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchToolName.Name = "txtSearchToolName";
            this.txtSearchToolName.Size = new System.Drawing.Size(143, 22);
            this.txtSearchToolName.TabIndex = 5;
            this.txtSearchToolName.TextChanged += new System.EventHandler(this.txtSearchToolName_TextChanged);
            // 
            // btnRentalReport
            // 
            this.btnRentalReport.Location = new System.Drawing.Point(800, 656);
            this.btnRentalReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRentalReport.Name = "btnRentalReport";
            this.btnRentalReport.Size = new System.Drawing.Size(241, 32);
            this.btnRentalReport.TabIndex = 10;
            this.btnRentalReport.Text = "Generate Rental Report";
            this.btnRentalReport.UseVisualStyleBackColor = true;
            this.btnRentalReport.Click += new System.EventHandler(this.btnRentalReport_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(1220, 12);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(524, 338);
            this.dgvCustomers.TabIndex = 20;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this.dgvCustomers_DoubleClick);
            // 
            // dgvTools
            // 
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(1220, 367);
            this.dgvTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.RowHeadersWidth = 51;
            this.dgvTools.RowTemplate.Height = 24;
            this.dgvTools.Size = new System.Drawing.Size(524, 396);
            this.dgvTools.TabIndex = 21;
            this.dgvTools.DoubleClick += new System.EventHandler(this.dgvTools_DoubleClick);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomerID.Location = new System.Drawing.Point(781, 46);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(109, 20);
            this.lblCustomerID.TabIndex = 58;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(979, 46);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(169, 22);
            this.txtCustomerID.TabIndex = 57;
            // 
            // txtDateTimeReturned
            // 
            this.txtDateTimeReturned.Enabled = false;
            this.txtDateTimeReturned.Location = new System.Drawing.Point(979, 412);
            this.txtDateTimeReturned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateTimeReturned.Name = "txtDateTimeReturned";
            this.txtDateTimeReturned.ReadOnly = true;
            this.txtDateTimeReturned.Size = new System.Drawing.Size(220, 22);
            this.txtDateTimeReturned.TabIndex = 56;
            // 
            // txtDateTimeRented
            // 
            this.txtDateTimeRented.Enabled = false;
            this.txtDateTimeRented.Location = new System.Drawing.Point(979, 375);
            this.txtDateTimeRented.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateTimeRented.Name = "txtDateTimeRented";
            this.txtDateTimeRented.ReadOnly = true;
            this.txtDateTimeRented.Size = new System.Drawing.Size(220, 22);
            this.txtDateTimeRented.TabIndex = 55;
            // 
            // lblDateTimeReturned
            // 
            this.lblDateTimeReturned.AutoSize = true;
            this.lblDateTimeReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateTimeReturned.Location = new System.Drawing.Point(781, 412);
            this.lblDateTimeReturned.Name = "lblDateTimeReturned";
            this.lblDateTimeReturned.Size = new System.Drawing.Size(165, 20);
            this.lblDateTimeReturned.TabIndex = 54;
            this.lblDateTimeReturned.Text = "Date/Time Returned:";
            // 
            // lblDateTimeRented
            // 
            this.lblDateTimeRented.AutoSize = true;
            this.lblDateTimeRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateTimeRented.Location = new System.Drawing.Point(781, 375);
            this.lblDateTimeRented.Name = "lblDateTimeRented";
            this.lblDateTimeRented.Size = new System.Drawing.Size(150, 20);
            this.lblDateTimeRented.TabIndex = 53;
            this.lblDateTimeRented.Text = "Date/Time Rented:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCondition.Location = new System.Drawing.Point(781, 199);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(121, 20);
            this.lblCondition.TabIndex = 52;
            this.lblCondition.Text = "Tool Condition:";
            // 
            // cbToolCondition
            // 
            this.cbToolCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToolCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbToolCondition.FormattingEnabled = true;
            this.cbToolCondition.Items.AddRange(new object[] {
            "Usuable",
            "Broken"});
            this.cbToolCondition.Location = new System.Drawing.Point(979, 199);
            this.cbToolCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbToolCondition.Name = "cbToolCondition";
            this.cbToolCondition.Size = new System.Drawing.Size(117, 24);
            this.cbToolCondition.TabIndex = 2;
            // 
            // txtSelectToolName
            // 
            this.txtSelectToolName.Enabled = false;
            this.txtSelectToolName.Location = new System.Drawing.Point(979, 332);
            this.txtSelectToolName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectToolName.Name = "txtSelectToolName";
            this.txtSelectToolName.ReadOnly = true;
            this.txtSelectToolName.Size = new System.Drawing.Size(169, 22);
            this.txtSelectToolName.TabIndex = 50;
            // 
            // txtSelectToolID
            // 
            this.txtSelectToolID.Enabled = false;
            this.txtSelectToolID.Location = new System.Drawing.Point(979, 287);
            this.txtSelectToolID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectToolID.Name = "txtSelectToolID";
            this.txtSelectToolID.ReadOnly = true;
            this.txtSelectToolID.Size = new System.Drawing.Size(103, 22);
            this.txtSelectToolID.TabIndex = 49;
            // 
            // lblSelectedToolName
            // 
            this.lblSelectedToolName.AutoSize = true;
            this.lblSelectedToolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelectedToolName.Location = new System.Drawing.Point(781, 332);
            this.lblSelectedToolName.Name = "lblSelectedToolName";
            this.lblSelectedToolName.Size = new System.Drawing.Size(165, 20);
            this.lblSelectedToolName.TabIndex = 48;
            this.lblSelectedToolName.Text = "Selected Tool Name:";
            // 
            // lblSelectedToolID
            // 
            this.lblSelectedToolID.AutoSize = true;
            this.lblSelectedToolID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelectedToolID.Location = new System.Drawing.Point(781, 287);
            this.lblSelectedToolID.Name = "lblSelectedToolID";
            this.lblSelectedToolID.Size = new System.Drawing.Size(138, 20);
            this.lblSelectedToolID.TabIndex = 47;
            this.lblSelectedToolID.Text = "Selected Tool ID:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(979, 155);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(169, 22);
            this.txtNotes.TabIndex = 1;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Enabled = false;
            this.txtCustomerSurname.Location = new System.Drawing.Point(979, 114);
            this.txtCustomerSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.ReadOnly = true;
            this.txtCustomerSurname.Size = new System.Drawing.Size(169, 22);
            this.txtCustomerSurname.TabIndex = 45;
            // 
            // lblRentSurname
            // 
            this.lblRentSurname.AutoSize = true;
            this.lblRentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRentSurname.Location = new System.Drawing.Point(781, 114);
            this.lblRentSurname.Name = "lblRentSurname";
            this.lblRentSurname.Size = new System.Drawing.Size(159, 20);
            this.lblRentSurname.TabIndex = 44;
            this.lblRentSurname.Text = "Customer Surname:";
            // 
            // lblRentName
            // 
            this.lblRentName.AutoSize = true;
            this.lblRentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRentName.Location = new System.Drawing.Point(781, 79);
            this.lblRentName.Name = "lblRentName";
            this.lblRentName.Size = new System.Drawing.Size(136, 20);
            this.lblRentName.TabIndex = 43;
            this.lblRentName.Text = "Customer Name:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNotes.Location = new System.Drawing.Point(781, 155);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(58, 20);
            this.lblNotes.TabIndex = 42;
            this.lblNotes.Text = "Notes:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(979, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(169, 22);
            this.txtName.TabIndex = 41;
            // 
            // cbToolStatus
            // 
            this.cbToolStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToolStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbToolStatus.FormattingEnabled = true;
            this.cbToolStatus.Items.AddRange(new object[] {
            "Active",
            "Retired"});
            this.cbToolStatus.Location = new System.Drawing.Point(979, 245);
            this.cbToolStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbToolStatus.Name = "cbToolStatus";
            this.cbToolStatus.Size = new System.Drawing.Size(117, 24);
            this.cbToolStatus.TabIndex = 3;
            // 
            // lblToolStatus
            // 
            this.lblToolStatus.AutoSize = true;
            this.lblToolStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToolStatus.Location = new System.Drawing.Point(781, 245);
            this.lblToolStatus.Name = "lblToolStatus";
            this.lblToolStatus.Size = new System.Drawing.Size(99, 20);
            this.lblToolStatus.TabIndex = 60;
            this.lblToolStatus.Text = "Tool Status:";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRentalID.Location = new System.Drawing.Point(781, 12);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(84, 20);
            this.lblRentalID.TabIndex = 61;
            this.lblRentalID.Text = "Rental ID:";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Enabled = false;
            this.txtRentalID.Location = new System.Drawing.Point(979, 12);
            this.txtRentalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new System.Drawing.Size(103, 22);
            this.txtRentalID.TabIndex = 62;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rb_All.Location = new System.Drawing.Point(800, 593);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(86, 22);
            this.rb_All.TabIndex = 6;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "All Tools";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.Click += new System.EventHandler(this.rbAll_Click);
            // 
            // btnToolsReport
            // 
            this.btnToolsReport.Location = new System.Drawing.Point(800, 709);
            this.btnToolsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToolsReport.Name = "btnToolsReport";
            this.btnToolsReport.Size = new System.Drawing.Size(241, 32);
            this.btnToolsReport.TabIndex = 11;
            this.btnToolsReport.Text = "Generate Tools Report";
            this.btnToolsReport.UseVisualStyleBackColor = true;
            this.btnToolsReport.Click += new System.EventHandler(this.btnToolsReport_Click);
            // 
            // frmRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 775);
            this.Controls.Add(this.btnToolsReport);
            this.Controls.Add(this.rb_All);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.cbToolStatus);
            this.Controls.Add(this.lblToolStatus);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtDateTimeReturned);
            this.Controls.Add(this.txtDateTimeRented);
            this.Controls.Add(this.lblDateTimeReturned);
            this.Controls.Add(this.lblDateTimeRented);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.cbToolCondition);
            this.Controls.Add(this.txtSelectToolName);
            this.Controls.Add(this.txtSelectToolID);
            this.Controls.Add(this.lblSelectedToolName);
            this.Controls.Add(this.lblSelectedToolID);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.lblRentSurname);
            this.Controls.Add(this.lblRentName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvTools);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnRentalReport);
            this.Controls.Add(this.txtSearchToolName);
            this.Controls.Add(this.txtSearchToolBrand);
            this.Controls.Add(this.lblSearchByToolName);
            this.Controls.Add(this.lblSearchByToolBrand);
            this.Controls.Add(this.rbUnhired);
            this.Controls.Add(this.rbHired);
            this.Controls.Add(this.lblFilterSearch);
            this.Controls.Add(this.btnCloseRentals);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.btnRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmRentals";
            this.Text = "Rentals";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCloseRentals;
        private System.Windows.Forms.Label lblFilterSearch;
        private System.Windows.Forms.RadioButton rbHired;
        private System.Windows.Forms.RadioButton rbUnhired;
        private System.Windows.Forms.Label lblSearchByToolBrand;
        private System.Windows.Forms.Label lblSearchByToolName;
        private System.Windows.Forms.TextBox txtSearchToolBrand;
        private System.Windows.Forms.TextBox txtSearchToolName;
        private System.Windows.Forms.Button btnRentalReport;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtDateTimeReturned;
        private System.Windows.Forms.TextBox txtDateTimeRented;
        private System.Windows.Forms.Label lblDateTimeReturned;
        private System.Windows.Forms.Label lblDateTimeRented;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.ComboBox cbToolCondition;
        private System.Windows.Forms.TextBox txtSelectToolName;
        private System.Windows.Forms.TextBox txtSelectToolID;
        private System.Windows.Forms.Label lblSelectedToolName;
        private System.Windows.Forms.Label lblSelectedToolID;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lblRentSurname;
        private System.Windows.Forms.Label lblRentName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbToolStatus;
        private System.Windows.Forms.Label lblToolStatus;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.Button btnToolsReport;
    }
}