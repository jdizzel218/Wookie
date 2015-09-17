// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_06
// Date: 9/17/2015 10:30 AM
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

namespace Lab_06
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Purpose: The Main entry point into the program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: When user 'tabs' out of the textbox calculate the turns per mile from the diameter of the wheel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtWhellDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            //1. Get user input about the diameter of the wheel in inches.
            //2. Store user input in a double, after parsing the text, called wheelDiameter
            //3. Create an event handler that when the user 'tabs' out of the box the calculation will be done.
            //4. Perform some math on the varibles.
            //5. Find the circumfrence of the wheel by C = pi * diameter
            //6. 1 mile = 63,360in so you take that number and divide it by C and you have the number of revolutions.
            //4. Output the calculation to the textbox of Turns per Mile.
            
        }
        /// <summary>
        /// Purpose: Clear the text from the textboxes when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //1.When clicked reset all the variables and textboxes back to their original state.
        }
        
    }
}


//Question #1 - a ++size

//Questions #2 - C - Pseudo-Code
