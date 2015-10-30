// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_05
// Date: 10/30/2015 1:48 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Psedo-Code:
1. Create a SalesInvoice object
2. Store the values entered by the user in that object using appropriate methods.
3. Use Methods to calculate the state and local tax, net sales value and gross sales value, state and local tax are: 7.45% and 2.5% respectively.
4. Display an invoice back to the user using a messagebox.
*/

using System;
using System.Windows.Forms;

namespace Proj_05
{
    public partial class FrmMain : Form
    {
        double numItems;
        double unitPrice;

        /// <summary>
        /// Purpose: Main Entry point into program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Clears the textboxes when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNumItems.Text = "";
            TxtUnitPrice.Text = "";
        }

        /// <summary>
        /// Purpose: Calculates the net, gross price & local, state tax, then outputs it to user when called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            SalesInvoice invoice = new SalesInvoice();

            if (double.TryParse(TxtNumItems.Text, out numItems))
            {
                if (double.TryParse(TxtUnitPrice.Text, out unitPrice))
                {
                    if (numItems >= 0 && unitPrice >= 0) //Makes sure the user doesn't enter any negative numbers.
                    {
                        invoice.NumItems = numItems;
                        invoice.UnitPrice = unitPrice;

                        string quantity = $"Sales Tickets...\nQuantity: {invoice.NumItems} units.\nUnit Price: {invoice.UnitPrice} each.\n";
                        string seperator = "--------------------------------\n";
                        string net   = $"Net Price: {invoice.CalcNetSales():C}\n";
                        string state = $"State Sales Tax: {invoice.CalcStateTax():C}\n";
                        string local = $"Local Sales Tax: {invoice.CalcLocalTax():C}\n";
                        string gross = $"Please Pay: {invoice.CalcGrossSale():C}\n";


                        MessageBox.Show(quantity + seperator + net + state + local + gross,"Sales Invoice");
                    }
                    else
                    {
                        MessageBox.Show("You have entered an incorrect number that is less than zero.\nPlease enter a valid number.","Error");
                    }
                }
                else
                {
                   MessageBox.Show("You have entered a something that is not a number. Please enter a number.", "Error");
                }
            }
            else
            {
                MessageBox.Show("You have entered a something that is not a number. Please enter a number.", "Error");

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
        /// Purpose: Allows the user to hit enter while in the txt box to calculate the sales invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Enter Key</param>
        private void TxtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                BtnBuy_Click(sender, e);
            }
        }

        /// <summary>
        /// Purpose: Displays an about box when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nCS 1400 Section 001\nProject #5\nSales Invoice", "About");
        }

        /// <summary>
        /// Purpose: Displays instructions to the user when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter in the amount of items you are buying, and the price for 1 of them.\nWatch the magic happen.", "Instructions");
        }
    }
}
