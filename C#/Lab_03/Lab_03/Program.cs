// File/Project Prolog
// Name: Matthew L. Cranford
// CS 1400 Section 001
// Project: Lab_03
// Date: 8/30/2015 7:35 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab_03
{
    static public class Program
    {
        static public void Main()
        {
            WriteLine("Hello! My name is Hal.");
            Write("Please type in your name: ");

            string name = Console.ReadLine();

            Write("Hello {0}, how old are you? ", name);

            int age = Convert.ToInt32(ReadLine());

            Write("How much money do you have, {0}? ", name);

            double money = Convert.ToDouble(ReadLine());

            Write("Finally, {0} what is your gender (M/F)? ", name);

            string gender = ReadLine().ToUpper();

            //Outputs all variables
            WriteLine();
            WriteLine("Name: {0}", name);
            WriteLine("Age: {0}", age);
            WriteLine("Amount of money: {0}", money);
            WriteLine("Gender: {0}", gender);

            Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Lab_03

