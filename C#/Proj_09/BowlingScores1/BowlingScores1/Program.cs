// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_09
// Date: 12/15/2015 10:27 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:
#1. Take input from user -> first name and bowling score on single line.
#2. Use the Split method to parse the input, the name goes in an array of strings, and the score in an array of ints
#3. If the user enters an empty line, then quit adding users and scores to the arrays.
#4. Calculate the highest score by keeping track and comparing the index of the highest score. Do this for the low score.
#5. Calculate the average by adding all of the scores together and diving by the total scores.
#6. Output the users and scores. Output the highest score, the lowest score and the average score.
*/

using System;


namespace BowlingScores1
{
    class Program
    {
        /// <summary>
        /// Purpose: Main Entry point into program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BowlTeam bowling = new BowlTeam();
            bowling.GetData();
            bowling.Bowlers();
            bowling.FindScore();

            Console.ReadKey(true);
        }

    }
}
