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
    public partial class frmCustomerDetails : Form
    {
        #region Main Form Methods
        // Declares and intializes various objects
        Customer customer = new Customer();
        Adapter adapter = new Adapter();
        bool isNew = true;

        // Main Methods to create the form when customer doesn't exist
        public frmCustomerDetails()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        // Main methods to create the form when customer exists
        public frmCustomerDetails(int id)
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Colour;
            isNew = false;
            ShowExistingCustomerDetails(id);
        }

        #endregion

        #region Various Methods for Functionality
        // Method to retrieve and show customer details on form
        private void ShowExistingCustomerDetails(int id)
        {
            customer = adapter.GetSingleCustomerDetails(id);
            txtCustomerID.Text = customer.CustomerID.ToString();
            txtCustomerName.Text = customer.Name;
            txtCustomerSurname.Text = customer.Surname;
            txtCustomerPhone.Text = customer.Phone;
        }

        // Method to save customer
        private void SaveNewCustomer()
        {
            if (AreTextFieldsCompleted())
            {
                customer.Name = txtCustomerName.Text;
                customer.Surname = txtCustomerSurname.Text;
                customer.Phone = txtCustomerPhone.Text;
                if (isNew)
                {
                    adapter.AddNewCustomer(customer);
                }
                else
                {
                    adapter.SaveExistingCustomer(customer);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        // Method to check if fields are all filled out - maintains data integrity
        private bool AreTextFieldsCompleted()
        {
            if (String.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtCustomerSurname.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtCustomerPhone.Text))
            {
                MessageBox.Show("Please fill in all details.");
                return false;
            }
            return true;
        }

        #endregion

        #region Button Clicks and Other Inputs
        // Ensures that only numerical values can be inputted into txtCustomerPhone
        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Saves Customer on Save Button Click
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            SaveNewCustomer();
        }

        //Closes Form
        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
