
namespace YourCommunityWorkshop
{
    partial class frmToolDetails
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
            this.cbProductCondition = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductNo = new System.Windows.Forms.TextBox();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.lblProductCondition = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductNo = new System.Windows.Forms.Label();
            this.btnSaveTool = new System.Windows.Forms.Button();
            this.btnCloseToolDetails = new System.Windows.Forms.Button();
            this.cbProductStatus = new System.Windows.Forms.ComboBox();
            this.txtProductBrand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbProductCondition
            // 
            this.cbProductCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductCondition.FormattingEnabled = true;
            this.cbProductCondition.Items.AddRange(new object[] {
            "Usuable",
            "Broken"});
            this.cbProductCondition.Location = new System.Drawing.Point(166, 111);
            this.cbProductCondition.Name = "cbProductCondition";
            this.cbProductCondition.Size = new System.Drawing.Size(121, 24);
            this.cbProductCondition.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(166, 42);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(205, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductNo
            // 
            this.txtProductNo.Enabled = false;
            this.txtProductNo.Location = new System.Drawing.Point(166, 12);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.ReadOnly = true;
            this.txtProductNo.Size = new System.Drawing.Size(205, 22);
            this.txtProductNo.TabIndex = 1;
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductStatus.Location = new System.Drawing.Point(10, 145);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(125, 20);
            this.lblProductStatus.TabIndex = 17;
            this.lblProductStatus.Text = "Product Status:";
            // 
            // lblProductCondition
            // 
            this.lblProductCondition.AutoSize = true;
            this.lblProductCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductCondition.Location = new System.Drawing.Point(10, 111);
            this.lblProductCondition.Name = "lblProductCondition";
            this.lblProductCondition.Size = new System.Drawing.Size(147, 20);
            this.lblProductCondition.TabIndex = 16;
            this.lblProductCondition.Text = "Product Condition:";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductBrand.Location = new System.Drawing.Point(10, 77);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(122, 20);
            this.lblProductBrand.TabIndex = 15;
            this.lblProductBrand.Text = "Product Brand:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductName.Location = new System.Drawing.Point(10, 42);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(121, 20);
            this.lblProductName.TabIndex = 14;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductNo
            // 
            this.lblProductNo.AutoSize = true;
            this.lblProductNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductNo.Location = new System.Drawing.Point(10, 12);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(98, 20);
            this.lblProductNo.TabIndex = 13;
            this.lblProductNo.Text = "Product No:";
            // 
            // btnSaveTool
            // 
            this.btnSaveTool.Location = new System.Drawing.Point(415, 12);
            this.btnSaveTool.Name = "btnSaveTool";
            this.btnSaveTool.Size = new System.Drawing.Size(85, 28);
            this.btnSaveTool.TabIndex = 6;
            this.btnSaveTool.Text = "Save";
            this.btnSaveTool.UseVisualStyleBackColor = true;
            this.btnSaveTool.Click += new System.EventHandler(this.btnSaveTool_Click);
            // 
            // btnCloseToolDetails
            // 
            this.btnCloseToolDetails.Location = new System.Drawing.Point(415, 46);
            this.btnCloseToolDetails.Name = "btnCloseToolDetails";
            this.btnCloseToolDetails.Size = new System.Drawing.Size(85, 28);
            this.btnCloseToolDetails.TabIndex = 7;
            this.btnCloseToolDetails.Text = "Close";
            this.btnCloseToolDetails.UseVisualStyleBackColor = true;
            this.btnCloseToolDetails.Click += new System.EventHandler(this.btnCloseToolDetails_Click);
            // 
            // cbProductStatus
            // 
            this.cbProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductStatus.FormattingEnabled = true;
            this.cbProductStatus.Items.AddRange(new object[] {
            "Active",
            "Retired"});
            this.cbProductStatus.Location = new System.Drawing.Point(166, 145);
            this.cbProductStatus.Name = "cbProductStatus";
            this.cbProductStatus.Size = new System.Drawing.Size(121, 24);
            this.cbProductStatus.TabIndex = 5;
            // 
            // txtProductBrand
            // 
            this.txtProductBrand.Location = new System.Drawing.Point(166, 77);
            this.txtProductBrand.Name = "txtProductBrand";
            this.txtProductBrand.Size = new System.Drawing.Size(205, 22);
            this.txtProductBrand.TabIndex = 3;
            // 
            // frmToolDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 182);
            this.Controls.Add(this.txtProductBrand);
            this.Controls.Add(this.cbProductStatus);
            this.Controls.Add(this.btnCloseToolDetails);
            this.Controls.Add(this.btnSaveTool);
            this.Controls.Add(this.cbProductCondition);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductNo);
            this.Controls.Add(this.lblProductStatus);
            this.Controls.Add(this.lblProductCondition);
            this.Controls.Add(this.lblProductBrand);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmToolDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbProductCondition;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductNo;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.Label lblProductCondition;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductNo;
        private System.Windows.Forms.Button btnSaveTool;
        private System.Windows.Forms.Button btnCloseToolDetails;
        private System.Windows.Forms.TextBox txtProductBrand;
        private System.Windows.Forms.ComboBox cbProductStatus;
    }
}