using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void uxMinPrice_Clicked(object sender, EventArgs e)
        {
            if (uxMinPrice.Text.Equals("Min Price"))
            {
                uxMinPrice.Text = "";
                uxMinPrice.ForeColor = Color.Black;
            }

        }
        private void uxMaxPrice_Clicked(object sender, EventArgs e)
        {
            if (uxMaxPrice.Text.Equals("Max Price"))
            {
                uxMaxPrice.Text = "";
                uxMaxPrice.ForeColor = Color.Black;
            }
        }
        private void uxMinBeds_Clicked(object sender, EventArgs e)
        {
            if (uxMinBeds.Text.Equals("Min Beds"))
            {
                uxMinBeds.Text = "";
                uxMinBeds.ForeColor = Color.Black;
            }
        }
        private void uxMaxBeds_Clicked(object sender, EventArgs e)
        {
            if (uxMaxBeds.Text.Equals("Max Beds"))
            {
                uxMaxBeds.Text = "";
                uxMaxBeds.ForeColor = Color.Black;
            }
        }
        private void uxMinBaths_Clicked(object sender, EventArgs e)
        {
            if (uxMinBaths.Text.Equals("Min Baths"))
            {
                uxMinBaths.Text = "";
                uxMinBaths.ForeColor = Color.Black;
            }
        }
        private void uxMaxBaths_Clicked(object sender, EventArgs e)
        {
            if (uxMaxBaths.Text.Equals("Max Baths"))
            {
                uxMaxBaths.Text = "";
                uxMaxBaths.ForeColor = Color.Black;
            }
        }

        private void uxLocationDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!uxLocationDropdown.Text.Equals("Location"))
            {
                uxLocationDropdown.ForeColor = Color.Black;
            }
        }

        private void uxParkingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!uxParkingDropdown.Text.Equals("Parking"))
            {
                uxParkingDropdown.ForeColor = Color.Black;
            }
        }

        private void uxPetsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!uxPetsDropdown.Text.Equals("Pets"))
            {
                uxPetsDropdown.ForeColor = Color.Black;
            }
        }

        private void uxLaundryDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!uxLaundryDropdown.Text.Equals("Laundry"))
            {
                uxLaundryDropdown.ForeColor = Color.Black;
            }
        }

        private void populateFlowLayoutPanel(int k) //bring in some data structure filled with unit data
        {
            for (int i = 0; i < k; i++)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.Blue;
                panel.Width = 600;
                uxUnitListPanel.Controls.Add(panel);
                Button button = new Button();
                button.BackColor = Color.Red;
                panel.Controls.Add(button);
            }
        }

        private void uxSearchBtn_Click(object sender, EventArgs e)
        {
            if (uxSearchBtn.Text.Equals("Search"))
                uxSearchBtn.Text = "Update Search";
            //call some method here that filters our data based on the input fields and return a data structure to pass into the next method call
            populateFlowLayoutPanel(30);
        }
    }

}
