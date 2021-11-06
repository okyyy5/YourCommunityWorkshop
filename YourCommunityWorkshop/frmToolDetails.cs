using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YCW_DataManagement;

namespace YourCommunityWorkshop
{
    public partial class frmToolDetails : Form
    {
        #region Main Methods to Manage GUI
        // Declaration of various objects
        Tool tool = new Tool();
        Adapter adapter = new Adapter();
        bool isNew = true;

        // Form constructor
        public frmToolDetails()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        // Construct form in a different manner if id is provided
        public frmToolDetails(int id)
        {
            InitializeComponent();
            isNew = false;
            ShowExistingToolDetails(id);
        }

        #endregion

        #region Button Clicks
        // Closes form on button click
        private void btnCloseToolDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Executes method on button click
        private void btnSaveTool_Click(object sender, EventArgs e)
        {
            SaveNewTool();
        }
        #endregion

        #region Methods for functionality
        // Recieves and assigns tool details to text boxes in form
        private void ShowExistingToolDetails(int id)
        {
            tool = adapter.GetSingleToolDetails(id);
            txtProductName.Text = tool.ToolName;
            txtProductBrand.Text = tool.ToolBrand;
            txtProductNo.Text = tool.ToolID.ToString();
            cbProductStatus.SelectedItem = tool.ToolStatus;
            cbProductCondition.SelectedItem = tool.ToolCondition;
        }
        // Saves and organises all the details of a tool
        private void SaveNewTool()
        {
            if (AreTextFieldsCompleted())
            {
                tool.ToolName = txtProductName.Text;
                tool.ToolBrand = txtProductBrand.Text;
                tool.ToolStatus = cbProductStatus.SelectedItem.ToString();
                tool.ToolCondition = cbProductCondition.SelectedItem.ToString();
                if (isNew) //Adds a new tool if tool is new
                {
                    adapter.AddNewTool(tool);
                }
                else  // Updates existing tool
                {
                    adapter.SaveExistingTool(tool);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        // Checks if all the text boxes are filled out for error handling
        private bool AreTextFieldsCompleted()
        {
            if (String.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtProductBrand.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            if (String.IsNullOrWhiteSpace(cbProductStatus.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            if (String.IsNullOrWhiteSpace(cbProductCondition.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            return true;
        }
        #endregion
    }
}