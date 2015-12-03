// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_22
// Date: 11/30/2015 2:10 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:
#1. Create integer array of 10 elements.
#2. Use a loop to fill the array by
    a. Prompting the user for a value
    b. Converts value into the right data type(int)
    c. Stores the value in the array.
#3. Passes the array to a method that adds up all the elements and returns a sum. The method must work on an array of any size.
#4. Outpus the sum of the array.
*/



using System;
namespace Lab_22
{
    class Program
    {
        const int ARRAY_SIZE = 10;
        /// <summary>
        /// Purpose: Main Entry point into Program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu();
        }
        /// <summary>
        /// Purpose: Allows the user to make a choice on what they want to do.
        /// </summary>
        static void Menu()
        {
            int userChoice;
            do
            {

                Console.WriteLine("Please select a choice: ");
                Console.WriteLine("1: Sum an array.");
                Console.WriteLine("0: Quit");

            } while (!int.TryParse(Console.ReadLine(), out userChoice));

            if( userChoice == 1)
            {
                SumArray();
            }
            else if(userChoice == 0)
            {
                Console.WriteLine("Good-Bye!");
                Environment.Exit(0);
            }
           
            
        }

        /// <summary>
        /// Purpose: Business logic of program.
        /// </summary>
        static void SumArray()
        {
            int[] array = new int[ARRAY_SIZE];
            GetData(array);
            var sum = Sum(array);
            Console.WriteLine($"\nThe sum is: {sum}.");
            Console.ReadKey(true);
        }
        /// <summary>
        /// Purpose: returns the sum of the array elements.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static int Sum(int[] values)
        {
            int sum = 0;
            foreach(int value in values)
            {
                sum += value;
            }
            return sum;
        }

        /// <summary>
        /// Purpose: Gets data from the user and stores it in the array.
        /// </summary>
        /// <param name="values"></param>
        static void GetData(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                int userValue;
                do
                {

                    Console.Write("Please enter a value for the array: ");

                } while(!int.TryParse(Console.ReadLine(), out userValue));

                    values[i] = userValue;
            }
        }
    }
}
