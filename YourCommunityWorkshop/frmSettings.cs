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
    public partial class frmSettings : Form
    {
        // Main methoid to build form
        public frmSettings()
        {
            InitializeComponent();
            this.BackColor = Properties.Settings.Default.Colour;
        }

        // Closes form on button click
        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        // Modifies Properties of Solution on button Click
        private void btnColour_Click(object sender, EventArgs e)
        {
            ColorDialog Color = new ColorDialog();

            if (Color.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Colour = Color.Color;  //Changes colour to specified colour
                Properties.Settings.Default.Save(); // Saves colour
            }
            
            this.BackColor = Properties.Settings.Default.Colour; //Assigns colour to settings form as a preview for other forms
        }
    }
}
