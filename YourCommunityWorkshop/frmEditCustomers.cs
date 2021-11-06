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
    public partial class frmEditCustomers : Form
    {

        #region Main Methods to Manage GUI

        // Declares various objects to manage the form
        List<Customer> initialList = new List<Customer>(); // Initial list of customers
        List<Customer> tempList = new List<Customer>();  // List to filter customers into
        List<Customer> viewList; // List that stores customers after filter

        Adapter adapter = new Adapter();

        // Form Constructor
        public frmEditCustomers()
        {
            InitializeComponent();
            SetupTableInitial();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        // Sets up Data Grid View with all customers
        private void SetupTableInitial()
        {
            initialList = adapter.GetAllCustomers();
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = initialList;
        }

        // Sets up Data Grid View to a filtered list
        private void SetupDataTable()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = viewList;
        }

        #endregion

        #region Button Clicks
        // Closes form on button click
        private void btnCloseCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        // Deletes customer on button click
        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.Rows.Count > 0) // Checks that there is at least 1 row in data grid view
                {
                    int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value;  // Retrieves id from row
                    DialogResult result = MessageBox.Show("Delete this customer?", "Confirmation", MessageBoxButtons.YesNo);  // Confirmation dialogue box
                    if (result == DialogResult.Yes)
                    {
                        adapter.DeleteSingleCustomer(id); // Deletes customer with that ID
                        SetupTableInitial(); // Updates Table
                        txtSearchCustomer.Text = ""; // Clears search box
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cannot delete customer while they rent something!");  // Catches SQL exception when customer is renting a tool
            }
            
        }


        // Shows existing customer details in customer details form when a customer is clicked in data grid view
        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers["CustomerID", dgvCustomers.CurrentCell.RowIndex].Value; // Retrieves id from row
            frmCustomerDetails frm = new frmCustomerDetails(id);  // Opens Customer Details form with id
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupTableInitial();  // Updates table when customer details form is closed
                txtSearchCustomer.Text = ""; // Clears search box
            }

        }

        // Opens Customer Details form to add new customer on button click
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetupTableInitial(); // Updates table when customer details form is closed
                txtSearchCustomer.Text = ""; // Clears search box
            }
        }
        #endregion

        #region Search and Filter Functions
        //Add Search Function to this table
        private void FilterListAndDisplay()
        {
            tempList.Clear();
            if (String.IsNullOrWhiteSpace(txtSearchCustomer.Text)) // Triggers when there is no text in search
            {
                viewList = initialList; // Sets the viewed list to the initial list
                SetupDataTable();
                return;
            }

            foreach (var customer in initialList)
            {
                bool isMatching = true;  
                if (customer.Name.IndexOf(txtSearchCustomer.Text, StringComparison.OrdinalIgnoreCase) == -1) // Compares text in search to name of customer (ignoring casing)
                {
                    isMatching = false;
                }

                if (isMatching) // If matching adds customer to tempList
                {
                    tempList.Add(customer);
                }
            }
            viewList = tempList;  // Transfers filters to viewList
            SetupDataTable();  // Updates data grid view to viewList
        }

        // Event that triggers anytime text is changed in customer search
        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            FilterListAndDisplay();
        }

        #endregion

        #region Generate Report

        // Generates csv report on button click
        private void btnReport_Click(object sender, EventArgs e)
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
                    string headings = "Customer ID, Name, Surname, Phone";
                    write.WriteLine(headings);  // Initially writes headings
                    foreach (var customer in viewList)
                    {
                        string line = $"{customer.CustomerID},{customer.Name},{customer.Surname},{customer.Phone}";  // Writes each line to document in this format
                        write.WriteLine(line);
                    }
                }
                SetupTableInitial(); // Resets Table
                txtSearchCustomer.Text = "";  // Clears search box
                MessageBox.Show("File succesfully saved");
            }
        }

        #endregion


    }
}
