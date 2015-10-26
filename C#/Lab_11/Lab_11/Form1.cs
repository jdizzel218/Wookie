// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_11
// Date: 10/12/2015 10:30 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Purpose: Main Entry point into program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            MessageBox.Show("Please note that if you enter a negative value that will automactically be changed to a positive one for you.", "Notice");

        }



        /// <summary>
        /// Purpose: Calculates the hypotenuse of a triangle.
        /// Parameters: side1 and side2
        /// Returns: double hypotenuse.
        /// </summary>
        /// <param name="side1">User input</param>
        /// <param name="side2">User Input</param>
        /// <returns></returns>
        static double CalcHypotenuse(double side1, double side2)
        {
            /*
            Pseudo-Code
            1. Take user input for side1 and side2.
            2. Call Math.Sqr on side1 and side2 and then add them together.
            3. Then call Math.Sqrt on the resultant.
            4. return resultant.
            */

            double hypotenuse = Math.Sqrt(((side1) * (side1)) + ((side2) * (side2)));

            return hypotenuse;
        }

        /// <summary>
        /// Purpose: When clicked, it will take the text from the textboxes and calculate the hypotenuse and display it to the user.
        /// Parameters: sender, e
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {

            /*
            Pseduo-Code:

            1. Take input from the user, if it can't be parsed raise an error message.
            2. Call the method previously created on user input.
            3. Output the calculated variable, in a proper format up to 2 decimal places.
            */
            double sideOne;
            double sideTwo;

            if (double.TryParse(TxtSideOne.Text, out sideOne))
            {
                if (double.TryParse(TxtSideTwo.Text, out sideTwo))
                {
                    double hypotenuse = CalcHypotenuse(sideOne, sideTwo);

                    TxtHypotenuse.Text = hypotenuse.ToString("#.##");

                }
                else
                {
                    MessageBox.Show("Please enter a correct positive value.", "Notice");
                }
            }
            else
            {
                MessageBox.Show("Please enter a correct positive value.", "Notice");
            }
        }
        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// Parameters: sender, e
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// Parameters: sender, e
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Purpose: Show an about message when clicked.
        /// Parameters: sender, e
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nCS1400 Section 001\nLab_11");
        }
    }// End FrmMain Class


    //Question #1: C - one.
    //Question #2: A - True
}// End Namespace
