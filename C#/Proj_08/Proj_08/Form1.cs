// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_08
// Date: 12/10/2015 2:22 PM

// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:

#1. When a user clicks on a button, simulate rolling a pair of die.
#2. Create a dice class that handles anything that has to do with dice (i.e which side was rolled, rolling the dice, etc).
#3. Display the output to the user using pictures, When the user rolls both 1's or 6's tell them that they rolled 'snake-eyes' or box-cars respectively.

*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proj_08
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Resource references for pictures.
        /// </summary>
        Image side1 = new Bitmap(Properties.Resources.side1);
        Image side2 = new Bitmap(Properties.Resources.side2);
        Image side3 = new Bitmap(Properties.Resources.side3);
        Image side4 = new Bitmap(Properties.Resources.side4);
        Image side5 = new Bitmap(Properties.Resources.side5);
        Image side6 = new Bitmap(Properties.Resources.side6);


        /// <summary>
        /// Class Level Constants
        /// </summary>
        const int SNAKE_EYES = 1;
        const int ROLLED2 = 2;
        const int ROLLED3 = 3;
        const int ROLLED4 = 4;
        const int ROLLED5 = 5;
        const int BOX_CARS = 6;

        Dice dice = new Dice(); //Dice object.


        /// <summary>
        /// Purpose: Main Entry Point into Program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Simulates rolling the die's 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRoll_Click(object sender, EventArgs e)
        {

            dice.PlayGame();
            DisplayPicture();
            if (dice.DiceOne == SNAKE_EYES && dice.DiceTwo == SNAKE_EYES)
            {
                LblDiceRoll.Text = "SNAKE-EYES!";
            }
            else if (dice.DiceOne == BOX_CARS && dice.DiceTwo == BOX_CARS)
            {
                LblDiceRoll.Text = "BOX-CARS!";
            }
            else
            {
                LblDiceRoll.Text = "";
            }

        }

        /// <summary>
        /// Purpose: Closes the program when called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Closes the program when called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Displays an about box when called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford\nCS1400 Section 001\nProject #8\nDice Game", "About");
        }

        /// <summary>
        /// Purpose: Displays an instruction box when called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuInstruc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the \"Roll 'Em\" button below to roll the dice!", "Insturctions");
        }

        /// <summary>
        /// Purpose: Changes the pictures of the dice, to what you have rolled.
        /// </summary>
        private void DisplayPicture()
        {


            switch (dice.DiceOne)
            {
                case SNAKE_EYES:
                    PBoxLeftDie.Image = side1;
                    break;

                case ROLLED2:
                    PBoxLeftDie.Image = side2;
                    break;

                case ROLLED3:
                    PBoxLeftDie.Image = side3;
                    break;

                case ROLLED4:
                    PBoxLeftDie.Image = side4;
                    break;

                case ROLLED5:
                    PBoxLeftDie.Image = side5;
                    break;

                case BOX_CARS:
                    PBoxLeftDie.Image = side6;
                    break;

            }
            switch (dice.DiceTwo)
            {
                case SNAKE_EYES:
                    PBoxRightDie.Image = side1;
                    break;

                case ROLLED2:
                    PBoxRightDie.Image = side2;
                    break;

                case ROLLED3:
                    PBoxRightDie.Image = side3;
                    break;

                case ROLLED4:
                    PBoxRightDie.Image = side4;
                    break;

                case ROLLED5:
                    PBoxRightDie.Image = side5;
                    break;

                case BOX_CARS:
                    PBoxRightDie.Image = side6;
                    break;

            }
        }
    }
}
