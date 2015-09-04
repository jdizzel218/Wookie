// Project: Lab 04
// Name: Matthew L. Cranford
// CS 1400 section 001
// I hereby declare that the following


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
        public FrmMenuStrip1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit Menu Item Event Handler method - Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // The exitToolStripMenuItem1 method
        // Purpose: To close the window and terminate the apllication
        // Parameters: the object generating the event 
        // and the event arguements
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// About Menu Item Event Handler method - Display a MessageBox with the About information in it.
        /// </summary>
        /// <param name="sender"> About Menu Item</param>
        /// <param name="e">NOT used</param>
        // The aboutToolStripMenuItem method
        // Purpose: Will display a messgebox with information regarding the author.
        // Parameters: the object generating the event and the event arguements
        // returns: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew L. Cranford\nCs1400 - Section 001\nLab #4", "About DialogBox");
        }
    }// End class FrmMenuStrip1
}// End namespace Lab_04

// Quiz
// Question 1 : C - method prologue

// Question 2 : B - event handler
