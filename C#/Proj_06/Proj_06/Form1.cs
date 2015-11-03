// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_06
// Date: 11/3/2015 2:25 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:

1. Get Input from user regarding Shipping Method, How the want to ship (category - by weight or by items) and how many items and whether they are shipping to AL or HA
2. Create a class that will store that data and perform the calculation of the shipping - total = number of items * category + surcharge, then base that total of what type of shipping method they are using.
3. Output that total back to the user in a easy to read format.
*/

using System;
using System.Windows.Forms;

namespace Proj_06
{
    public partial class FrmMain : Form
    {
        const double STN_SHIP_A = 3.00;
        const double STN_SHIP_B = 1.45;
        const double EXP_SHIP_A = 4.00;
        const double EXP_SHIP_B = 2.50;
        const double SAME_SHIP_A = 5.50;
        const double SAME_SHIP_B = 3.00;

        const double STN_SHIP_SUR = 2.50;
        const double EXP_SHIP_SUR = 5.00;
        const double SAME_SHIP_SUR = 8.00;

        int NumItems;


        /// <summary>
        /// Purpose: Main Entry point of program
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Calculates the shipping and outputs it to user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Shipping ship = new Shipping();
            string shipMethod = CBoxShipMethod.Text;
            string category = CBoxCategory.Text;
            
            if(int.TryParse(TxtNumItems.Text, out NumItems))
            {
                ship.NumItems = NumItems;
                if (NumItems > 0)
                {
                    switch (shipMethod)
                    {
                        case "Standard":
                            if (category == "A - Per Item")
                            {
                                if (RBtnSurchargeYes.Checked)
                                    ship.Surcharge = STN_SHIP_SUR;

                                ship.Category = STN_SHIP_A;

                                string total = $"Please pay: {ship.CalcShipping():C}";

                                MessageBox.Show(total, "Total");

                            }
                            else //Category == B
                            {
                                if (RBtnSurchargeYes.Checked)
                                    ship.Surcharge = STN_SHIP_SUR;

                                ship.Category = STN_SHIP_B;
                                string total = $"Please pay: {ship.CalcShipping():C}";
                                MessageBox.Show(total, "Total");
                            }
                            break;

                        case "Express":

                            if (category == "A - Per Item")
                            {
                                if (RBtnSurchargeYes.Checked)
                                    ship.Surcharge = EXP_SHIP_SUR;

                                ship.Category = EXP_SHIP_A;
                                string total = $"Please pay: {ship.CalcShipping():C}";
                                MessageBox.Show(total, "Total");
                            }
                            else //Category == B
                            {
                                if (RBtnSurchargeYes.Checked)
                                    ship.Surcharge = EXP_SHIP_SUR;

                                ship.Category = EXP_SHIP_B;
                                string total = $"Please pay: {ship.CalcShipping():C}";
                                MessageBox.Show(total, "Total");
                            }
                            break;

                        case "Same-Day":
                            if (category == "A - Per Item")
                            {
                                if (RBtnSurchargeYes.Checked)
                                    ship.Surcharge = SAME_SHIP_SUR;

                                ship.Category = SAME_SHIP_A;
                                string total = $"Please pay: {ship.CalcShipping():C}";
                                MessageBox.Show(total, "Total");
                            }
                            else //category == B
                            {
                                if (RBtnSurchargeYes.Checked)
                                    ship.Surcharge = SAME_SHIP_SUR;

                                ship.Category = SAME_SHIP_B;
                                string total = $"Please pay: {ship.CalcShipping():C}";
                                MessageBox.Show(total, "Total");
                            }
                            break;
                        default:
                            MessageBox.Show("You have selected an incorrect shipping method\nPlease try again.", "Error");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("You aren't shipping anything, so I guess it's free.", "FREEDOM!");
                }
            }
            else
            {
                MessageBox.Show("You have entered an incorrect value.\nPlease try again.","Error");
            }
           
            
            
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Shows an about message when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nCS1400 Section 001\nProject #6", "About");
        }

        /// <summary>
        /// Purpose: Provides instructions to the user on how to use the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuInstruc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked your desired method of shipping and whether you wish to ship by items or by pounds, then selected if you are shipping to AL or HA and enter the number of items you are shipping.");
        }
    }
}
