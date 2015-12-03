// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_23
// Date: 11/30/2015 2:30 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------



/*
Pseudo-Code:

#1. Modify the program from lab_22 but have it handle an unfilled-array, by passing the length as a value into the Sum Method.


*/

using System;
namespace Lab_23
{
    class Program
    {

        const int ARRAY_SIZE = 100;
        
        /// <summary>
        /// Purpose: Main Entry point into Program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu();

        }

        /// <summary>
        /// Purpose: returns the sum of the array elements.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static int Sum(int[] values, int dataLength)
        {
            int sum = 0;
            
            for(int i = 0; i < dataLength; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        /// <summary>
        /// Purpose: Gets data from the user and stores it in the array.
        /// </summary>
        /// <param name="values"></param>
        static int GetData(int[] values)
        {
            
            for (int i = 0; i < values.Length; i++)
            {
                int userValue;
                do
                {

                    Console.Write("Please enter a value for the array, Enter 0 when done: ");

                } while (!int.TryParse(Console.ReadLine(), out userValue));

                if (userValue == 0) //Breaks the loop when the user enters 0.
                    return i; //returns how many the length of how many numbers was stored in the array.

                values[i] = userValue;
            }
            return values.Length; //If they manage to get through the entire array (100) then it will return that length.
        }

        /// <summary>
        /// Purpose: Helps the user choose what they would like to do.
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

            if (userChoice == 1)
            {
                //User chose to sum array.
                SumArray();
            }
            else if (userChoice == 0)
            {
                //Exit
                Console.WriteLine("Good-Bye!");
                Environment.Exit(0);
            }


        }

        /// <summary>
        /// Purpose: When a user chooses to sum an array they come here. It holds the logic for the program.
        /// </summary>
       static void SumArray()
        {
            int[] array = new int[ARRAY_SIZE];
            int count = GetData(array);
            var sum = Sum(array, count);
            Console.WriteLine($"\nThe Sum is: {sum}.");
            Console.ReadKey(true);
        }
    }
}
