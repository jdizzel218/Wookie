﻿// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_04
// Date: 9/4/2015 700 PM
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

namespace Lab_04
{
    public partial class FrmMenuStrip1 : Form
    {
        /// <summary>
        /// Purpose: Main entry point of program.
        /// </summary>
        public FrmMenuStrip1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit Menu Item Event Handler method - Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void MnuStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// About Menu Item Event Handler method - Display a MessageBox with the About information in it.
        /// </summary>
        /// <param name="sender"> About Menu Item</param>
        /// <param name="e">NOT used</param>
       
        private void MnuStripAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew L. Cranford\nCs1400 - Section 001\nLab #4", "About DialogBox");
        }
        /// <summary>
        /// Purpose: To close the program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close(); //Closes the button
        }
    }// End class FrmMenuStrip1
}// End namespace Lab_04

// Quiz
// Question 1 : C - method prologue

// Question 2 : B - event handler