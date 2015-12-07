// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_21
// Date: 12/4/2015 3:50 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:
#1. Take user input on the amount of change they want to calculate for (1-99)
#2. Compute the number of 50 cent pieces you can take out of it, do this for quarters, dimes, nickels, and pennies.
#3. Compute the new number to be passed in to the method.
#4. Output to user.

*/





using System;
using static System.Console;

namespace Lab_21
{
    class Program
    {

        //Some Class level constants

        const int HALVES = 50;
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int PENNIES = 1;

        static void Main(string[] args)
        {
            Menu();
        }

        static public void Menu()
        {
            //code to continue to compute change or quit
            TestChangeProg();
        }

        static public void TestChangeProg()
        {
            string change = ""; //input change'
            int money = 0; // values we want to count change for
            int coins = 0; // coins from ComputeChange()
            WriteLine("I will make change for you.");
            Write("Enter in an amount between 1 and 99 ");
            if(!int.TryParse((change = ReadLine()), out money))
            {
                WriteLine($"Invalid change value -> {change}, please re-enter");
                ReadKey(true);
                return;
            }

            WriteLine($"For {money} you get:");
            ComputeChange(ref money, HALVES, out coins);
            WriteLine($"{coins} halves");
            ComputeChange(ref money, QUARTERS, out coins);
            WriteLine($"{coins} quarters");
            ComputeChange(ref money, DIMES, out coins);
            WriteLine($"{coins} dimes");
            ComputeChange(ref money, NICKELS, out coins);
            WriteLine($"{coins} nickels");
            ComputeChange(ref money, PENNIES, out coins);
            WriteLine($"{coins} pennies\n");
            ReadKey(true);
        }

        /// <summary>
        /// Purpose: Calculates the coin amount for any given number of change.
        /// </summary>
        /// <param name="changeValue">the amount of change</param>
        /// <param name="coinValue"> the value of coins</param>
        /// <param name="numberCoins">the number of coins</param>
        static void ComputeChange(ref int changeValue, int coinValue, out int numberCoins)
        {

            numberCoins = changeValue / coinValue;
            changeValue %= coinValue;
           

        }
    }
}
