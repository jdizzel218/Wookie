// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_20
// Date: 11/6/2015 2:31 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------


/*

Pseudo-Code:

#1. Create a method that takes 2 values and swaps them.
#2. Create a method that takes 2 values and swaps them, but you pass them by out.
*/

using System;
using static System.Console;

namespace Lab_20
{
    class Program
    {
        /// <summary>
        /// Purpose: Main Entry point of program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 15;


            //call the Swap method and out the result.
            //Swap(ref number1, ref number2);

            Swap(number1, number2, out number1, out number2);
            WriteLine($"number1 = {number1:D}");
            WriteLine($"number2 = {number2:D}");

            ReadKey(true);
        }
        /// <summary>
        /// Purpose: Swaps values of two integers.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        static public void Swap(ref int n1, ref int n2)
        {
            int temp = n1;

            n1 = n2;
            n2 = temp;
        }

        /// <summary>
        /// Purpose: Swaps values of two integers.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="no1"></param>
        /// <param name="no2"></param>
        static public void Swap(int n1, int n2, out int no1, out int no2)
        {
            no1 = n2;
            no2 = n1;
        }
    }

   
}
