// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_01
// Date: 9/12/2015 1:25 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------



//Peusdo-Code:
// 1. Get input from the user regarding the price of their meal.
// 2. When the user tabs out of the box, calculate the tip for 10%, 15%, and 20% upto 2 decimal places
// 3. Output the calculated tip back to the user.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_01
{ 
    public partial class FrmMain : Form
    {
        //Init variables and constants.
        double _mealCost;
        const double TEN     = .10; //10 percent.
        const double FIFTEEN = .15; //15 percent.
        const double TWENTY  = .20; //20 percent.
        /// <summary>
        /// Purpose: Initialize the FrmMain
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Purpose: Closes the App. from the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Shows an 'about' message box when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford \nCS1400 Section 001", "About"); //displays message box.
        }

        /// <summary>
        /// Purpose: Calculates all the meal tips when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            _mealCost = Convert.ToDouble(TxtMealCost.Text);

            TxtPoor.Text      = (_mealCost * TEN).ToString("N2"); //calculates poor service and returns a string with 2 decimal places
            TxtAverage.Text   = (_mealCost * FIFTEEN).ToString("N2"); //Same as above but for average service.
            TxtExcellent.Text = (_mealCost * TWENTY).ToString("N2"); // Same as above but for excellent service.

        }
        /// <summary>
        /// Purpose: Calculates tip if user 'tabs' out of the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMealCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                _mealCost = Convert.ToDouble(TxtMealCost.Text);

                TxtPoor.Text      = (_mealCost * TEN).ToString("N2"); //calculates poor service and returns a string with 2 decimal places
                TxtAverage.Text   = (_mealCost * FIFTEEN).ToString("N2"); //Same as above but for average service.
                TxtExcellent.Text = (_mealCost * TWENTY).ToString("N2"); // Same as above but for excellent service.

            }
        }
    } //End main
}// End Namespace
