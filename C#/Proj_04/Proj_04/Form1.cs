// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_04
// Date: 10/17/2015 11:04 PM
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
using static System.Math;

namespace Proj_04
{
  
    
    public partial class FrmMain : Form
    {
        const int LAW_OF_COSINES = 2;
        const double DEGREES_IN_RADIANS = 180.00;
        double sideA;
        double sideB;
        double angleC;
        

        /// <summary>
        /// Purpose: Main Entry point into program
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            MessageBox.Show("If you enter a negative number, it will be converted to a positive one for you.", "Notice");
        }
        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender">Not used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Displays an about box when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nCS1400 Section 001\nProject #4", "About");
        }

        /// <summary>
        /// Purpose: Displays a box to help the user use the program when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter in two positive side lengths and the angle of C,\nThen watch the magic happen.");
        }

        /// <summary>
        /// Purpose: Clears all Textboxes and resets all variables when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //TextBoxes
            TxtSideA.Text  = "";
            TxtSideB.Text  = "";
            TxtSideC.Text  = "";
            TxtAngleC.Text = "";

            sideA  = 0;
            sideB  = 0;
            angleC = 0;
        }

        /// <summary>
        /// Purpose: Calculates sideC
        /// </summary>
        /// <param name="sideA">User Input</param>
        /// <param name="sideB">User Input</param>
        /// <param name="angleC">User Input</param>
        public static double CalcSideC(double sideA, double sideB, double angleC)
        {
            double sideC;

            sideC = Sqrt((sideA * sideA) + (sideB * sideB) - (LAW_OF_COSINES * sideA * sideB * Cos(angleC)));

            return sideC;
        }
        /// <summary>
        /// Purpose: Calculates sideC and outputs it when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if(double.TryParse(TxtSideA.Text, out sideA))
            {
                if(double.TryParse(TxtSideB.Text, out sideB))
                {
                    if(double.TryParse(TxtAngleC.Text, out angleC))
                    {
                        angleC = (angleC * PI) / DEGREES_IN_RADIANS;
                         
                        TxtSideC.Text = CalcSideC(sideA, sideB, angleC).ToString("#.###");


                    }
                }
            }
        }


    }//End Class main

}//End Namespace proj_04



