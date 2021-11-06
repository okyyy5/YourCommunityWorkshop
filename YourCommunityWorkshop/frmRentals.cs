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
    public partial class frmRentals : Form
    {
        #region Main Form Methods
        // Various objects that are utilized in this form
        Customer customer = new Customer();
        Tool tool = new Tool();
        Rental rental = new Rental();
        Rental returned = new Rental();
        List<Rental> rentalList = new List<Rental>(); 

        List<Tool> toolList = new List<Tool>(); // Initial Lists without filters
        List<Tool> modtoolList = new List<Tool>(); // List to filter into
        List<Tool> viewtoolList = new List<Tool>(); // List after removing unactive and broken tools
        List<Tool> initialList = new List<Tool>(); // Initial List for filters
        List<Tool> tempList = new List<Tool>(); // List to filter into
        List<Tool> viewList = new List<Tool>(); // List after removing unactive and broken tools and assigning filters

        List<Customer> customerList = new List<Customer>();
        Adapter adapter = new Adapter();

        // Form constructor
        public frmRentals()
        {
            InitializeComponent();
            SetupDataTable();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        /// <summary>
        /// Initial Set up of Data Grid view - without any filters etc.
        /// </summary>
        /// <returns> Base Data Grid View </returns>
        private void SetupDataTable()
        {
            rentalList = adapter.GetAllRentals();
            toolList = adapter.GetAllTools();
            customerList = adapter.GetAllCustomers();
            RemoveUnactiveAndBrokenTools();
            ResetFiltersAndTable();
            dgvCustomers.DataSource = null;
            dgvRentals.DataSource = null;
            dgvTools.DataSource = null;
            initialList = viewtoolList;
            dgvRentals.DataSource = rentalList;
            dgvTools.DataSource = viewtoolList;
            dgvCustomers.DataSource = customerList;
        }

        // Filtered Update of data grid view
        private void FilterSetupDataTable()
        {
            dgvTools.DataSource = null;

            dgvTools.DataSource = viewList;
        }
        #endregion

        #region Button Events
        // Closes form on button click
        private void btnCloseRentals_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Executes rent function on button click
        private void btnRent_Click(object sender, EventArgs e)
        {
            if (IsCustomerToolSelected())  // Various checks to ensure data integrity
            {
                if (IsToolOnRent())
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to rent this tool?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Assign rental details through text boxes in GUI
                        MessageBox.Show("Reminder: Tool Condition and Tool Status cannot be edited when renting.");
                        Rental rental = new Rental(Int32.Parse(txtCustomerID.Text), Int32.Parse(txtSelectToolID.Text),DateTime.Now);
                        rental.Notes = txtNotes.Text;
                        rental.DateRented = DateTime.Now;
                        rental.DateReturned = null;
                        rental.CustomerID = Int32.Parse(txtCustomerID.Text);
                        rental.ToolID = Int32.Parse(txtSelectToolID.Text);

                        // Updates rent status of tool
                        tool = adapter.GetSingleToolDetails(Int32.Parse(txtSelectToolID.Text));
                        tool.RentStatus = true;

                        // Saves Tool and Adds new rental
                        adapter.SaveExistingTool(tool);
                        adapter.AddNewRental(rental);

                        // Resets Table
                        SetupDataTable();
                        
                        MessageBox.Show("Tool Successfully Rented.");
                        
                    }
                
                }
                
            }
            
        }

        // Executes Return function on button click
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtRentalID.Text)) // Checks for data integrity
            {
                MessageBox.Show("Please select a Rental to return.");
            }
            else 
            {
                DialogResult result = MessageBox.Show("Are you sure you want to return this tool?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Recieves rental information from text boxes
                    returned.RentalID = Int32.Parse(txtRentalID.Text);
                    returned.CustomerID = Int32.Parse(txtCustomerID.Text);
                    returned.ToolID = Int32.Parse(txtSelectToolID.Text);
                    returned.Notes = txtNotes.Text;
                    returned.DateRented = DateTime.Parse(txtDateTimeRented.Text);
                    returned.DateReturned = DateTime.Now;
                    txtDateTimeReturned.Text = returned.DateReturned.ToString();

                    // Recieves tool information and Updates it
                    tool = adapter.GetSingleToolDetails(Int32.Parse(txtSelectToolID.Text));
                    tool.RentStatus = false;
                    tool.ToolStatus = cbToolStatus.SelectedItem.ToString();
                    tool.ToolCondition = cbToolCondition.SelectedItem.ToString();
                    tool.Notes = txtNotes.Text;
                    adapter.SaveExistingTool(tool);

                    // Deletes old rental with no date returned and creates identical rental with date returned data
                    adapter.DeleteSingleRental(Int32.Parse(txtRentalID.Text));
                    adapter.AddNewRental(returned);

                    // Resets Table
                    txtRentalID.Text = "";
                    SetupDataTable(); 
                    MessageBox.Show("Tool Successfully Returned.");
                    
                }
            }
        }

        
        #endregion

        #region Search and Filter functions
        private void FilterListAndDisplay()
        {
            // Triggers when there is no text in both searches and active and retired radio buttons are not checked
            if (String.IsNullOrWhiteSpace(txtSearchToolName.Text) && String.IsNullOrWhiteSpace(txtSearchToolBrand.Text) && rbHired.Checked == false && rbUnhired.Checked == false)
            {
                tempList.Clear();
                viewList = initialList; // Sets the viewed list to the initial list
                FilterSetupDataTable();
                return;
            }

            // Triggers when there is NO text in both searches
            if (String.IsNullOrWhiteSpace(txtSearchToolName.Text) && String.IsNullOrWhiteSpace(txtSearchToolBrand.Text))
            {
                tempList.Clear();
                foreach (var tool in initialList)
                {
                    bool isMatching = true;
                    if (rbHired.Checked == true && tool.RentStatus == false)
                    {
                        isMatching = false;
                    }

                    if (rbUnhired.Checked == true && tool.RentStatus == true)
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

                    if (rbHired.Checked == true && tool.RentStatus == false)
                    {
                        isMatching = false;
                    }

                    if (rbUnhired.Checked == true && tool.RentStatus == true)
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

                    if (rbHired.Checked == true && tool.RentStatus == false)
                    {
                        isMatching = false;
                    }

                    if (rbUnhired.Checked == true && tool.RentStatus == true)
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

                    if (rbHired.Checked == true && tool.RentStatus == false)
                    {
                        isMatching = false;
                    }

                    if (rbUnhired.Checked == true && tool.RentStatus == true)
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
            FilterSetupDataTable();  // Updates data grid view to viewList
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

        // Event that triggers anytime radio button hired is checked
        private void rbHired_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        // Event that triggers anytime radio button unhired is checked
        private void rbUnhired_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        // Event that triggers anytime radio button all is checked
        private void rbAll_Click(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }
        #endregion

        #region Generate Rental Report
        // Generates csv report on button click
        private void btnRentalReport_Click(object sender, EventArgs e)
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
                    string headings = "Rental ID, Customer ID, Tool ID, Date Rented, Date Returned, Notes";
                    write.WriteLine(headings);  // Initially writes headings
                    foreach (var rental in rentalList)
                    {
                        string line = $"{rental.RentalID},{rental.CustomerID},{rental.ToolID},{rental.DateRented},{rental.DateReturned},{rental.Notes}";  // Writes each line to document in this format
                        write.WriteLine(line);
                    }
                }
                SetupDataTable(); // Resets Table
                MessageBox.Show("File succesfully saved");
            }
            ResetFiltersAndTable();
        }

        // Generates csv report on button click
        private void btnToolsReport_Click(object sender, EventArgs e)
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
                    string headings = "Tool ID, Tool Name, Tool Brand, Tool Condition, Tool Status, Rent Status, Notes";
                    write.WriteLine(headings);  // Initially writes headings
                    foreach (var tool in viewList)
                    {
                        string line = $"{tool.ToolID},{tool.ToolName},{tool.ToolBrand},{tool.ToolCondition},{tool.ToolStatus},{tool.RentStatus},{tool.Notes}";  // Writes each line to document in this format
                        write.WriteLine(line);
                    }
                }
                SetupDataTable(); // Resets Table
                MessageBox.Show("File succesfully saved");
            }
            ResetFiltersAndTable();
        }
        #endregion

        #region Other Internal Functionalities
        // Assigns selected customer information to text boxes
        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value; // Grabs id
            customer = adapter.GetSingleCustomerDetails(id); // Grabs all other information in accordance to id
            txtCustomerID.Text = id.ToString();
            txtName.Text = customer.Name;
            txtCustomerSurname.Text = customer.Surname;
        }

        // Assigns selected tool information to text boxes
        private void dgvTools_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvTools["ToolID", dgvTools.CurrentCell.RowIndex].Value; // Grabs id
            tool = adapter.GetSingleToolDetails(id); // Grabs all other information in accordance to id
            txtSelectToolID.Text = id.ToString();
            txtSelectToolName.Text = tool.ToolName;
            cbToolCondition.SelectedItem = tool.ToolCondition;
            cbToolStatus.SelectedItem = tool.ToolStatus;
            txtNotes.Text = tool.Notes;
        }

        // Assigns rental information to text boxes
        private void dgvRentals_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvRentals["RentalID", dgvRentals.CurrentCell.RowIndex].Value; // Grabs rental id
            rental = adapter.GetSingleRentalDetails(id); // Grabs all other rental information in accordance to id
            txtRentalID.Text = rental.RentalID.ToString();
            txtNotes.Text = rental.Notes;
            txtDateTimeRented.Text = rental.DateRented.ToString();
            txtDateTimeReturned.Text = rental.DateReturned.ToString();
            txtCustomerID.Text = rental.CustomerID.ToString();
            txtSelectToolID.Text = rental.ToolID.ToString();
            txtNotes.Text = rental.Notes;

            customer = adapter.GetSingleCustomerDetails(rental.CustomerID); // Grabs customer information with customerID in rental
            txtName.Text = customer.Name;
            txtCustomerSurname.Text = customer.Surname;

            tool = adapter.GetSingleToolDetails(rental.ToolID); // Grabs tool information with toolID in rental
            txtSelectToolID.Text = tool.ToolID.ToString();
            txtSelectToolName.Text = tool.ToolName;
            cbToolCondition.SelectedItem = tool.ToolCondition;
            cbToolStatus.SelectedItem = tool.ToolStatus;

        }

        // Check if customer tool is selected before performaing action
        private bool IsCustomerToolSelected()
        {
            if (String.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Please select a Customer.");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtSelectToolID.Text))
            {
                MessageBox.Show("Please select a Tool.");
                return false;
            }
            return true;
        }

        // Checks if tool is on rent before performing action
        private bool IsToolOnRent()
        {
            tool = adapter.GetSingleToolDetails(Int32.Parse(txtSelectToolID.Text));
            if (tool.RentStatus == true)
            {
                MessageBox.Show("This tool is already rented. Please return it or select a different tool.");
                return false;
            }
            return true;
        }

        // Removes all unactive and broken tools to provide data integrity to rentals
        private void RemoveUnactiveAndBrokenTools()
        {
            modtoolList.Clear();
            foreach (Tool tool in toolList)
            {
                if (tool.ToolCondition == "Usuable" && tool.ToolStatus == "Active")
                {
                    modtoolList.Add(tool);
                }
            }
            viewtoolList = modtoolList;
        }

        // Resets almost all table GUI elements
        private void ResetFiltersAndTable()
        {
            // Clears all information
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtCustomerSurname.Text = "";
            txtSelectToolID.Text = "";
            txtSelectToolName.Text = "";
            txtDateTimeRented.Text = "";
            txtDateTimeReturned.Text = "";
            txtNotes.Text = "";
            txtRentalID.Text = "";

            txtSearchToolBrand.Text = "";  // Clears search box
            txtSearchToolName.Text = ""; // Clears search box
            rbHired.Checked = false; // Button 3 reset radio buttons
            rbUnhired.Checked = false;
            rb_All.Checked = true;
        }

        #endregion
    }
}
