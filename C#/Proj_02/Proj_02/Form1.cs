// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_02
// Date: 9/19/2015 4:53 PM

// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code

1. Take input from user about the total gold and Crew members
2. Calculate how much Jack gets
3. Calculate how much the First Mate gets 
4. Calculate how much the PBA gets
5. Split the gold evenly among the crew
6. Display the amounts to textboxes.

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

namespace Proj_02
{
    public partial class FrmMain : Form
    {

        const double TWELVEPERCENT = .12;
        const double EIGHTPERCENT   = .08;
        const int CAPTNNFIRSTMATE = 2;
        const int FUNGOLD = 3;

        int _totalGold; 
        int _crewMembers;
        int _remainingCrewMembers;
        int _remainingGold;
        int _capnJackShare;
        int _firstMateShare;
        int _pbaShare;
        int _crewShare;
        int _auditor;


        /// <summary>
        /// Purpose: The Main Entry point into the program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Shows the 'about' box when clicked
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford \nCourse: CS1400 Section: 001 \nProject 2: Captain Jack", "About");
        }

        /// <summary>
        /// Purpose: Closes the program when clicked.
        /// </summary>
        /// <param name="sender">Not used</param>
        /// <param name="e">Not Used</param>
        private void BtnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: When clicked, do all calculations on the gold based on totalGold and Number of crew members.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSplitGold_Click(object sender, EventArgs e)
        {
             if(int.TryParse(TxtTotalGold.Text, out _totalGold))
                if(int.TryParse(TxtNumberPirates.Text, out _crewMembers))
                {
                    _remainingCrewMembers = _crewMembers - CAPTNNFIRSTMATE;


                    _capnJackShare = (int)(_totalGold * TWELVEPERCENT);
                    _firstMateShare = (int)((_totalGold -_capnJackShare) * EIGHTPERCENT);

                    _remainingGold = (_totalGold - _capnJackShare - _firstMateShare);  


                    _crewShare = (_remainingGold / _crewMembers);

                    _capnJackShare  += _crewShare;
                    _firstMateShare += _crewShare;

                    if (_remainingGold % _crewMembers == 0) //This is to check if the there is any remaining gold which wasn't split evenly among the crew.
                    {
                        _pbaShare = 0;
                    }
                    else
                    {
                        _pbaShare = _remainingGold % _crewMembers;
                    }

                     _auditor = _capnJackShare + _firstMateShare + (_crewShare * _remainingCrewMembers) + _pbaShare; //This calculates all of the shares and makes sure you didn't go over, **debugging purposes.**

                    //Output to Textboxes
                    TxtCapnShare.Text      = _capnJackShare.ToString();
                    TxtFirstMateShare.Text = _firstMateShare.ToString();
                    TxtCrewShare.Text      = _crewShare.ToString();
                    TxtPbaShare.Text       = _pbaShare.ToString();
                    TxtAuditor.Text        = _auditor.ToString();
                }

        }

        /// <summary>
        /// Purpose: If the user press enter or tab while in this text box it will focus on the next textbox. It makes it more intuitive to use.
        /// </summary>
        /// <param name="sender">Not used</param>
        /// <param name="e">Enter or Tab</param>
        private void TxtNumberPirates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                TxtTotalGold.Focus();
            }

            if(e.KeyCode == Keys.Enter)
            {
                TxtTotalGold.Focus();
            }
        }

        /// <summary>
        /// Purpose: When the user press enter in the total gold text box, this function will call the BtnSplitGold method, it basically does the same thing as if the user click 'Split the Gold!'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtTotalGold_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnSplitGold_Click(sender,e);
            }
        }
    } //End Main
}//End Namespace Proj_02
