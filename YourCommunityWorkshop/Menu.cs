using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourCommunityWorkshop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        #region Button Clicks
        
        // Buttons below open various forms in accordance to the button that was clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmEditCustomers frm = new frmEditCustomers();
            frm.ShowDialog();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            frmEditTools frm = new frmEditTools();
            frm.ShowDialog();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            frmRentals frm = new frmRentals();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Properties.Settings.Default.Colour; // Updates Menu colour after button is closed
            }
        }
        #endregion
    }
}
