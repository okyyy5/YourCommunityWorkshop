
namespace YourCommunityWorkshop
{
    partial class frmEditTools
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
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.btnCloseTools = new System.Windows.Forms.Button();
            this.btnAddTool = new System.Windows.Forms.Button();
            this.btnDeleteTool = new System.Windows.Forms.Button();
            this.lblFilterSearch = new System.Windows.Forms.Label();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbRetired = new System.Windows.Forms.RadioButton();
            this.txtSearchToolName = new System.Windows.Forms.TextBox();
            this.lblToolName = new System.Windows.Forms.Label();
            this.lblSearchToolBrand = new System.Windows.Forms.Label();
            this.txtSearchToolBrand = new System.Windows.Forms.TextBox();
            this.btnExportToolReport = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTools
            // 
            this.dgvTools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(12, 12);
            this.dgvTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.RowHeadersWidth = 51;
            this.dgvTools.RowTemplate.Height = 24;
            this.dgvTools.Size = new System.Drawing.Size(573, 426);
            this.dgvTools.TabIndex = 13;
            this.dgvTools.DoubleClick += new System.EventHandler(this.dgvTools_DoubleClick);
            // 
            // btnCloseTools
            // 
            this.btnCloseTools.Location = new System.Drawing.Point(704, 409);
            this.btnCloseTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseTools.Name = "btnCloseTools";
            this.btnCloseTools.Size = new System.Drawing.Size(85, 30);
            this.btnCloseTools.TabIndex = 9;
            this.btnCloseTools.Text = "Close";
            this.btnCloseTools.UseVisualStyleBackColor = true;
            this.btnCloseTools.Click += new System.EventHandler(this.btnCloseTools_Click);
            // 
            // btnAddTool
            // 
            this.btnAddTool.Location = new System.Drawing.Point(597, 12);
            this.btnAddTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(85, 28);
            this.btnAddTool.TabIndex = 1;
            this.btnAddTool.Text = "Add";
            this.btnAddTool.UseVisualStyleBackColor = true;
            this.btnAddTool.Click += new System.EventHandler(this.btnAddTool_Click);
            // 
            // btnDeleteTool
            // 
            this.btnDeleteTool.Location = new System.Drawing.Point(703, 12);
            this.btnDeleteTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTool.Name = "btnDeleteTool";
            this.btnDeleteTool.Size = new System.Drawing.Size(85, 28);
            this.btnDeleteTool.TabIndex = 2;
            this.btnDeleteTool.Text = "Delete";
            this.btnDeleteTool.UseVisualStyleBackColor = true;
            this.btnDeleteTool.Click += new System.EventHandler(this.btnDeleteTool_Click);
            // 
            // lblFilterSearch
            // 
            this.lblFilterSearch.AutoSize = true;
            this.lblFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilterSearch.Location = new System.Drawing.Point(637, 53);
            this.lblFilterSearch.Name = "lblFilterSearch";
            this.lblFilterSearch.Size = new System.Drawing.Size(105, 20);
            this.lblFilterSearch.TabIndex = 17;
            this.lblFilterSearch.Text = "Filter/Search";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbActive.Location = new System.Drawing.Point(597, 134);
            this.rbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(122, 24);
            this.rbActive.TabIndex = 4;
            this.rbActive.Text = "Active Tools";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.Click += new System.EventHandler(this.rbActive_Click);
            // 
            // rbRetired
            // 
            this.rbRetired.AutoSize = true;
            this.rbRetired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbRetired.Location = new System.Drawing.Point(597, 182);
            this.rbRetired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRetired.Name = "rbRetired";
            this.rbRetired.Size = new System.Drawing.Size(130, 24);
            this.rbRetired.TabIndex = 5;
            this.rbRetired.Text = "Retired Tools";
            this.rbRetired.UseVisualStyleBackColor = true;
            this.rbRetired.Click += new System.EventHandler(this.rbRetired_Click);
            // 
            // txtSearchToolName
            // 
            this.txtSearchToolName.Location = new System.Drawing.Point(597, 269);
            this.txtSearchToolName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchToolName.Name = "txtSearchToolName";
            this.txtSearchToolName.Size = new System.Drawing.Size(191, 22);
            this.txtSearchToolName.TabIndex = 6;
            this.txtSearchToolName.TextChanged += new System.EventHandler(this.txtSearchToolName_TextChanged);
            // 
            // lblToolName
            // 
            this.lblToolName.AutoSize = true;
            this.lblToolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToolName.Location = new System.Drawing.Point(596, 231);
            this.lblToolName.Name = "lblToolName";
            this.lblToolName.Size = new System.Drawing.Size(120, 20);
            this.lblToolName.TabIndex = 21;
            this.lblToolName.Text = "By Tool Name:";
            // 
            // lblSearchToolBrand
            // 
            this.lblSearchToolBrand.AutoSize = true;
            this.lblSearchToolBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchToolBrand.Location = new System.Drawing.Point(595, 304);
            this.lblSearchToolBrand.Name = "lblSearchToolBrand";
            this.lblSearchToolBrand.Size = new System.Drawing.Size(121, 20);
            this.lblSearchToolBrand.TabIndex = 22;
            this.lblSearchToolBrand.Text = "By Tool Brand:";
            // 
            // txtSearchToolBrand
            // 
            this.txtSearchToolBrand.Location = new System.Drawing.Point(597, 338);
            this.txtSearchToolBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchToolBrand.Name = "txtSearchToolBrand";
            this.txtSearchToolBrand.Size = new System.Drawing.Size(191, 22);
            this.txtSearchToolBrand.TabIndex = 7;
            this.txtSearchToolBrand.TextChanged += new System.EventHandler(this.txtSearchToolBrand_TextChanged);
            // 
            // btnExportToolReport
            // 
            this.btnExportToolReport.Location = new System.Drawing.Point(600, 381);
            this.btnExportToolReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToolReport.Name = "btnExportToolReport";
            this.btnExportToolReport.Size = new System.Drawing.Size(92, 57);
            this.btnExportToolReport.TabIndex = 8;
            this.btnExportToolReport.Text = "Export Tool Report";
            this.btnExportToolReport.UseVisualStyleBackColor = true;
            this.btnExportToolReport.Click += new System.EventHandler(this.btnExportToolReport_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbAll.Location = new System.Drawing.Point(597, 89);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(95, 24);
            this.rbAll.TabIndex = 3;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Tools";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Click += new System.EventHandler(this.rbAll_Click);
            // 
            // frmEditTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.btnExportToolReport);
            this.Controls.Add(this.txtSearchToolBrand);
            this.Controls.Add(this.lblSearchToolBrand);
            this.Controls.Add(this.lblToolName);
            this.Controls.Add(this.txtSearchToolName);
            this.Controls.Add(this.rbRetired);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.lblFilterSearch);
            this.Controls.Add(this.btnDeleteTool);
            this.Controls.Add(this.btnAddTool);
            this.Controls.Add(this.btnCloseTools);
            this.Controls.Add(this.dgvTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmEditTools";
            this.Text = "Tools";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.Button btnCloseTools;
        private System.Windows.Forms.Button btnAddTool;
        private System.Windows.Forms.Button btnDeleteTool;
        private System.Windows.Forms.Label lblFilterSearch;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbRetired;
        private System.Windows.Forms.TextBox txtSearchToolName;
        private System.Windows.Forms.Label lblToolName;
        private System.Windows.Forms.Label lblSearchToolBrand;
        private System.Windows.Forms.TextBox txtSearchToolBrand;
        private System.Windows.Forms.Button btnExportToolReport;
        private System.Windows.Forms.RadioButton rbAll;
    }
}