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
       
    {/// <summary>
    /// Purpose: To take input from the user and write the input to screen.
    /// </summary>
        static public void Main()
        {
            /// init variables.
            string name;
            int age;
            double money;
            string gender;

            WriteLine("Hello! My name is Hal."); //Says hello to user
            Write("Please type in your name: "); //Gets users name

            name = Console.ReadLine(); //stores users name in 'name'

            Write("Hello {0}, how old are you? ", name); //Gets user's age

            age = Convert.ToInt32(ReadLine()); //stores age 

            Write("How much money do you have, {0}? ", name); //gets users money

            money = Convert.ToDouble(ReadLine()); //stores money

            Write("Finally, {0} what is your gender (M/F)? ", name); //gets users gender

            gender = ReadLine().ToUpper(); //stores gender in CAPS  

            //Outputs all variables
            
            Write("Thank you {0}! ", name);
            Write("You are {0} years old ", age);
            Write("and have {0} dollars. ", money);

            //special line that only gets written in the user puts 'F' for their gender.
            WriteLine($"{((gender[0] =='F')?"Ladies get a special prize!" : "")}");

            Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()
    }//End class Program
}//End namespace Lab_03

