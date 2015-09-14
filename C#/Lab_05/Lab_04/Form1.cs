// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_05
// Date: 9//2015 2:25 PM
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
    /// <summary>
    /// Class: defines the form
    /// </summary>
    public partial class FrmMenuStrip1 : Form
    {
        int _inputVal;
        int _outputVal;
        const int MULT = 2;
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
            MessageBox.Show("Matthew L. Cranford\nCS1400 - Section 001\nLab #5", "About DialogBox");
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
        /// <summary>
        /// Purpose: Leave-Event handler to double the value entered in TxtInput
        /// </summary>
        /// <param name="sender">Txt Input</param>
        /// <param name="e">NOT used</param>
        private void TxtInput_Leave(object sender, EventArgs e)
        {
           

            if (int.TryParse(TxtInput.Text, out _inputVal)) 
            {
                TxtOutput.Text = $"{_inputVal * MULT:D}";
                TxtOutput.Focus();
            }
            else{
                TxtInput.Text = $"{TxtInput.Text} -> Invalid int";
                TxtInput.Focus();
            }
                      
        }
        /// <summary>
        /// Calculate the sum of the values in Txtinput and TxtOutput textboxes and place their sum in LblSum.
        /// </summary>
        /// <param name="sender">KeyPress Event in TxtOutput</param>
        /// <param name="e">Key Pressed</param>
        private void TxtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (int.TryParse(TxtOutput.Text, out _outputVal))
                {
                    LblSum.Text = $"Sum:{(_inputVal + _outputVal),20:D}";
                    TxtInput.Focus();
                }
                else
                {
                    TxtOutput.Text = $"{ TxtOutput.Text} -> Invalid int";
                    TxtOutput.Focus();
                }
            }
        }
    }// End class FrmMenuStrip1
}// End namespace Lab_04

// Quiz
// Question 1 : 
//              double cash = 4.56;
//              Textbox.Text = cash.ToString("N2");

// Question 2 : 
            //if (int.TryParse(TxtInput.Text, out _inputVal)) 
            //{
                //TxtOutput.Text = $"{_inputVal / MULT:D}"; ***Changed the operator to '/' ****
                //TxtOutput.Focus();
            //}
            //else{
                //TxtInput.Text = $"{TxtInput.Text} -> Invalid int";
                //TxtInput.Focus();
            //}
