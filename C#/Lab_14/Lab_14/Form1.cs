// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_14
// Date: 10/28/2015 2:25 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*

Pseudo-Code:

1. Create a class for a right Triangle.
2. Get Input from user and store them in variables sideA and sideB
3. Calculate the area and hypontenuse of the right triangle with those variables.
4. Display those calulcations back to the user.

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class FrmMain : Form
    {
        RightTriangle _tri;
        double sideA;
        double sideB;

        /// <summary>
        /// Purpose: Main Entry point of program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Calls RightTriangle class methods to calculate the area and hyp and outputs them to user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtrnCalc_Click(object sender, EventArgs e)
        {
            if(double.TryParse(TxtSideA.Text, out sideA))
            {
                if(double.TryParse(TxtSideB.Text, out sideB))
                {
                    if(sideA > 0 && sideB > 0)
                    {
                        _tri = new RightTriangle();

                        TxtHypotenuse.Text = _tri.CalcHypotenuse(sideA, sideB).ToString("#.##");
                        TxtArea.Text = _tri.CalcArea(sideA, sideB).ToString("#.##");
                    }
                    else
                    {
                        MessageBox.Show("You have either entered in a negative value or zero which is incorrect.\nPlease enter a valid positive value.", "Notice");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Make sure you put in a correct value", "Notice");
                }
            }
            
            
        }
        /// <summary>
        /// Purpose: Closes program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Closes program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Purpose: Displays an about messagebox when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nLab 15\nCS 1400 Section 001.", "About");
        }

        private void MnuStripInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter in the sides of the triangle to calculate both the hypontenuse and the area.", "Instructions");
        }
    }
}
