// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_13
// Date: 10/21/2015 9:16 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Windows.Forms;

/*
Pseudo-Code

1. Create a class called TokenMachine
2. Add fields of NumQuarters and NumTokens,
3. Create properties to get the class fields
4. Create methods for resetting the tokens & quarters && for incrementing and decrementing the quarters and tokens.
5. Create event handlers to call the TokenMachine class methods. (specifically reset() and getToken())


*/

namespace TokenMachine
{
    public partial class FrmMain : Form
    {
        private TokenMachine _tm;


        /// <summary>
        /// Purpose: Initializes the Main Form.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Purpose: Main Entry Point into program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _tm = new TokenMachine();
            _tm.Reset();
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Shows an about message when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nCS1400 Section 001\nLab #13");
        }
        /// <summary>
        /// Purpose: Resets tokens and quarters, and updates txtboxes when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _tm.Reset();
            TxtNumOfQuarters.Text = _tm.CountQuarters.ToString();
            TxtNumOfTokens.Text = _tm.CountTokens.ToString();
            TxtTokensDispensed.Text = _tm.TokensDispensed.ToString();

        }
        /// <summary>
        /// Purpose: This closes the program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Calls the GetToken method and updates Textboxes when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetToken_Click(object sender, EventArgs e)
        {
            if (_tm.CountQuarters >= 0 && _tm.CountTokens > 0)
            {
                _tm.GetToken();
                TxtNumOfTokens.Text = _tm.CountTokens.ToString();
                TxtNumOfQuarters.Text = _tm.CountQuarters.ToString();
                TxtTokensDispensed.Text = _tm.TokensDispensed.ToString();
            }
            else
            {
                MessageBox.Show("There are no more tokens to dispense. Please reset the Token Machine.", "Notice");
            }
        }

        /// <summary>
        /// Purpose: Explains how to use the program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Get Token to insert a quarter and get a token in return.");
        }
    }
}
