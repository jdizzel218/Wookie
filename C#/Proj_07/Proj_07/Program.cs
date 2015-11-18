// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_7
// Date: 11/7/2015 7:13 PM
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
#3. Output the answer to user.


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
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            

            int month = 1;
            int numAdults = 1;
            int numBabies = 0;
            int total = 1;


            DisplayStudentInfo();

            Console.WriteLine($"\tMonth\tAdults\tBabies\tTotal");
            Console.WriteLine("\t===============================");

            while (total <= TOTALCAGES)
            {
               
                Console.WriteLine($"\t{month}\t{numAdults}\t{numBabies}\t{total}");

               CalcRabbits(ref numBabies, ref numAdults);
               

                month += 1;
                total = numAdults + numBabies;

                
            }

            Console.WriteLine($"\n\t*Will run out of cages in month {month}*");

            Console.ReadKey(true);

        }

        /// <summary>
        /// Purpose: Calculates the number of rabbits using the fibbinoci sequence.
        /// </summary>
        /// <param name="previousRabbits"></param>
        /// <param name="currentRabbits"></param>
        /// <returns></returns>
        public static int CalcRabbits(ref int previousRabbits, ref int currentRabbits)
        {
            int temp;

            temp = currentRabbits + previousRabbits;

            previousRabbits = currentRabbits;
            currentRabbits = temp;

            return currentRabbits;
        }


       public static void DisplayStudentInfo()
        {
            Console.WriteLine("Matthew Cranford\nCS1400 Section 001\nProject #7\n'Rabbits,Rabbits,Rabbits'\n");
        }
    }
}
    

