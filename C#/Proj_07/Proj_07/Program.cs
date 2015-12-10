// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_7
// Date: 12/10/2015 1:46 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:

#1. Derive algrithom from looking at the pattern in worksheet. ((fibbinoci sequence))
#2. Fn = Fn-1 + Fn-2 (The fibinoci sequence) Fn is equal the two number previous to it.
#3. Have a method for Displaying Student Info
#4. Have a method that does the calculation for the rabbits, and pass both arguements as reference.
#5. Format the answers into a table, make sure to calculate the month in which the cages will run out.
#6. Output the answer to user.

*/

using System;

namespace Proj_07
{
    class Program
    {
        const int TOTALCAGES = 500;

        /// <summary>
        /// Purpose: Main Entry point of program.
        /// </summary>
        static void Main()
        {

            int month = 1;
            int numAdults = 1;
            int numBabies = 0;
            int totalNumRabbits = 1;


            DisplayStudentInfo();

            Console.WriteLine($"Month\tAdults\tBabies\tTotal");
            Console.WriteLine("=============================");

            while (totalNumRabbits <= TOTALCAGES)
            {

                Console.WriteLine($"{month}\t{numAdults}\t{numBabies}\t{totalNumRabbits}");

                CalcRabbits(ref numBabies, ref numAdults);

                month += 1;

                totalNumRabbits = numAdults + numBabies;


            }

            Console.WriteLine($"\n*Will run out of cages in month {month}*");

            Console.ReadKey(true);

        }

        /// <summary>
        /// Purpose: Calculates the number of rabbits using the fibbinoci sequence.
        /// </summary>
        /// <param name="previousRabbits"></param>
        /// <param name="currentRabbits"></param>
        /// <returns></returns>
        public static void CalcRabbits(ref int previousRabbits, ref int currentRabbits)
        {
            int temp;

            temp = currentRabbits + previousRabbits;

            previousRabbits = currentRabbits;
            currentRabbits = temp;

        }

        /// <summary>
        /// Purpose: Displays student info when called.
        /// </summary>
        public static void DisplayStudentInfo()
        {
            Console.WriteLine("Matthew Cranford\nCS1400 Section 001\nProject #7\nRabbits,Rabbits,Rabbits\n");
        }
    }
}


