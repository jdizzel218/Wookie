using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_21
{
    class Program
    {

        //Some Class level constants

        const int HALVES = 50;
        const int QUARTERS = 25;
        const int DIMES = 10;
        const int NICKELS = 5;
        const int PENNIES = 10;

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

            


        }
    }
}
