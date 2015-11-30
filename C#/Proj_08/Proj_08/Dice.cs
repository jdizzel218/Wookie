// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_08
// Date: 11/9/2015 3:48 PM
//
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

namespace Proj_08
{
    class Dice
    {
        const int HIGHESTVALUE = 7;
        const int LOWESTVALUE = 1;

        Random random = new Random();
        /// <summary>
        /// Property value for LeftDie
        /// </summary>
        public int Dice1
        {
            get; set;
        }

        /// <summary>
        /// Property value for RightDie
        /// </summary>
        public int Dice2
        {
            get; set;
        }

        /// <summary>
        /// Purpose: simulates rolling the dice.
        /// </summary>
        public void RollDice()
        {
            // Roll the dice.
            Dice1 = random.Next(LOWESTVALUE, HIGHESTVALUE);
            Dice2 = random.Next(LOWESTVALUE, HIGHESTVALUE);


        }

        
    }
}
