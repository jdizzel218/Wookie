// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_17
// Date: 12/7/2015 2:48 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_17
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Purpose: Main Entry point into program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Purpose: Tells the user they selected Same Day shipping.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnSameDay_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnSameDay.Checked)
            {
                MessageBox.Show("You have selected Same-Day shipping.");
            }
            
        }
        /// <summary>
        /// Purpose: Tells the user they have selected Express Shipping.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnExpress_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnExpress.Checked)
            {
                MessageBox.Show("You have selected Express shipping.");
            }
        }

        /// <summary>
        /// Purpose: Tells the user they have selected Standard Shipping.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnStandard.Checked)
            {
                MessageBox.Show("You have selected Standard shipping.");

            }
        }
    }
}
