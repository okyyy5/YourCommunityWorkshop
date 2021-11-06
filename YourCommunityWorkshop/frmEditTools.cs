using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YCW_DataManagement;

namespace YourCommunityWorkshop
{
    public partial class frmEditTools : Form
    {
        #region Main Methods to Manage GUI
        // Declaration of various objects
        List<Tool> initialList = new List<Tool>(); // Initial List of Tools
        List<Tool> tempList = new List<Tool>(); // List to filter tools into
        List<Tool> viewList = new List<Tool>(); // Final list of tools
        Adapter adapter = new Adapter();
        Tool tool = new Tool();

        //Form Constructor
        public frmEditTools()
        {
            InitializeComponent();
            SetupTableInitial();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        // Sets up Data Grid View with all tools
        private void SetupTableInitial()
        {
            initialList = adapter.GetAllTools();
            dgvTools.DataSource = null;
            dgvTools.DataSource = initialList;
        }

        // Sets up Data Grid View to a filtered list
        private void SetupDataTable()
        {
            dgvTools.DataSource = null;
            dgvTools.DataSource = viewList;
        }
        #endregion

        #region Button Clicks
        // Close form on button click
        private void btnCloseTools_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Opens Tool Details form to add new tool on button click
        private void btnAddTool_Click(object sender, EventArgs e)
        {
            frmToolDetails frm = new frmToolDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupTableInitial();
            }
            ResetFilters();
        }

        // Deletes selected tool on button click
        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            if (CheckRentStatus())  // Check if tool is on rent
            {
                if (dgvTools.Rows.Count > 0)  // Checks that there is at least 1 value in data grid view to delete
                {
                    int id = (int)dgvTools["ToolID", dgvTools.CurrentCell.RowIndex].Value;  // Retrieves id of selected tool in data grid view
                    DialogResult result = MessageBox.Show("Delete this tool?", "Confirmation", MessageBoxButtons.YesNo);  // Confirmation message box to confirm choice
                    if (result == DialogResult.Yes)
                    {
                        adapter.DeleteSingleTool(id);  // Deletes tool at specified id
                        SetupTableInitial();  // Resets Table
                    }
                }
            }
            ResetFilters();
        }

        // Opens Tool Details form with existing tool details when tool is double clicked in data grid view
        private void dgvTools_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvTools["ToolID", dgvTools.CurrentCell.RowIndex].Value; // Retrieves id of selected tool in data grid view
            frmToolDetails frm = new frmToolDetails(id);  // Opens Tool Details form with selected id
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupTableInitial();  // Resets Table
            }
            ResetFilters();
        }
        #endregion

        #region Methods for functionality
        // Method to check if tool is on rent
        private bool CheckRentStatus()
        {
            int id = (int)dgvTools["ToolID", dgvTools.CurrentCell.RowIndex].Value; // Retrieves id of selected tool in data grid view
            tool = adapter.GetSingleToolDetails(id); //Retrieves all information about tool with id
            if (tool.RentStatus == true)
            {
                MessageBox.Show("Please return this item before deleting it.");
                return false;
            }
            return true;
        }

        // Resets all filters to empty
        private void ResetFilters()
        {
            txtSearchToolBrand.Text = "";  // Clears search box
            txtSearchToolName.Text = ""; // Clears search box
            rbActive.Checked = false; // Button 3 reset radio buttons
            rbRetired.Checked = false;
            rbAll.Checked = true;
        }
        #endregion

        #region Search and Filter Functions
        private void FilterListAndDisplay()
        {
            // Triggers when there is no text in both searches and active and retired radio buttons are not checked
            if (String.IsNullOrWhiteSpace(txtSearchToolName.Text) && String.IsNullOrWhiteSpace(txtSearchToolBrand.Text) && rbActive.Checked == false && rbRetired.Checked == false) 
            {
                tempList.Clear();
                viewList = initialList; // Sets the viewed list to the initial list
                SetupDataTable();
                return;
            }

            // Triggers when there is NO text in both searches
            if (String.IsNullOrWhiteSpace(txtSearchToolName.Text) && String.IsNullOrWhiteSpace(txtSearchToolBrand.Text))
            {
                tempList.Clear();
                foreach (var tool in initialList)
                {
                    bool isMatching = true;
                    if (rbActive.Checked == true && tool.ToolStatus == "Retired")
                    {
                        isMatching = false;
                    }

                    if (rbRetired.Checked == true && tool.ToolStatus == "Active")
                    {
                        isMatching = false;
                    }

                    if (isMatching) // If matching adds tool to tempList
                    {
                        tempList.Add(tool);
                    }
                }
            }

            // Triggers when there is text in both searches
            if (!String.IsNullOrWhiteSpace(txtSearchToolName.Text) && !String.IsNullOrWhiteSpace(txtSearchToolBrand.Text))
            {
                tempList.Clear();
                foreach (var tool in initialList)
                {
                    bool isMatching = true;
                    if (tool.ToolBrand.IndexOf(txtSearchToolBrand.Text, StringComparison.OrdinalIgnoreCase) == -1 || tool.ToolName.IndexOf(txtSearchToolName.Text, StringComparison.OrdinalIgnoreCase) == -1) 
                    {
                        isMatching = false;
                    }

                    if (rbActive.Checked == true && tool.ToolStatus == "Retired")
                    {
                        isMatching = false;
                    }

                    if (rbRetired.Checked == true && tool.ToolStatus == "Active")
                    {
                        isMatching = false;
                    }

                    if (isMatching) // If matching adds tool to tempList
                    {
                        tempList.Add(tool);
                    }
                }
            }

            // Triggers when there is no text in tool brand search
            if (String.IsNullOrWhiteSpace(txtSearchToolBrand.Text))
            {
                tempList.Clear();
                foreach (var tool in initialList)
                {
                    bool isMatching = true;
                    if (tool.ToolName.IndexOf(txtSearchToolName.Text, StringComparison.OrdinalIgnoreCase) == -1) // Compares text in search to name of tool (ignoring casing)
                    {
                        isMatching = false;
                    }

                    if (rbActive.Checked == true && tool.ToolStatus == "Retired")
                    {
                        isMatching = false;
                    }

                    if (rbRetired.Checked == true && tool.ToolStatus == "Active")
                    {
                        isMatching = false;
                    }

                    if (isMatching) // If matching adds tool to tempList
                    {
                        tempList.Add(tool);
                    }
                }
            }
            

            // Triggers when there is no text in tool name search
            if (String.IsNullOrWhiteSpace(txtSearchToolName.Text))
            {
                tempList.Clear();
                foreach (var tool in initialList)
                {
                    bool isMatching = true;
                    if (tool.ToolBrand.IndexOf(txtSearchToolBrand.Text, StringComparison.OrdinalIgnoreCase) == -1) // Compares text in search to brand of tool (ignoring casing)
                    {
                        isMatching = false;
                    }

                    if (rbActive.Checked == true && tool.ToolStatus == "Retired")
                    {
                        isMatching = false;
                    }

                    if (rbRetired.Checked == true && tool.ToolStatus == "Active")
                    {
                        isMatching = false;
                    }

                    if (isMatching) // If matching adds tool to tempList
                    {
                        tempList.Add(tool);
                    }
                }
            }
            viewList = tempList;  // Transfers filtered objects to viewList
            SetupDataTable();  // Updates data grid view to viewList
        }


        // Event that triggers anytime text is changed in tool name search
        private void txtSearchToolName_TextChanged(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        // Event that triggers anytime text is changed in tool brand search
        private void txtSearchToolBrand_TextChanged(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        // Event that triggers anytime radio button retired is checked
        private void rbRetired_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        // Event that triggers anytime radio button active is checked
        private void rbActive_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        // Event that triggers anytime radio button all is checked
        private void rbAll_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }


        #endregion

        #region Generate Report

        // Generates csv report on button click
        private void btnExportToolReport_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay(); // Runs through filter
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Comma Separated Values(*.csv)|*.csv";  // Filters saving to only as csv file
            save.OverwritePrompt = true;  // Prompts for overwrite for files with same name



            if (save.ShowDialog() == DialogResult.OK)
            {

                var filePath = save.FileName;

                using (StreamWriter write = new StreamWriter(filePath))
                {
                    try
                    {
                        string headings = "Tool ID, Tool Name, Tool Brand, Tool Condition, Tool Status, Rent Status, Notes";
                        write.WriteLine(headings);  // Initially writes headings
                        foreach (var tool in viewList)
                        {
                            string line = $"{tool.ToolID},{tool.ToolName},{tool.ToolBrand},{tool.ToolCondition},{tool.ToolStatus},{tool.RentStatus},{tool.Notes}";  // Writes each line to document in this format
                            write.WriteLine(line);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    
                }
                SetupTableInitial(); // Resets Table
                MessageBox.Show("File succesfully saved");
            }
            ResetFilters();
        }

        #endregion
    }
}
