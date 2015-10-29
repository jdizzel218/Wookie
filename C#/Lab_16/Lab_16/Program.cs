// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_16
// Date: 10/29/2015 10:25 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_16
{
    class Program
    {
        const string SAT = "Saturday";
        const string SUN = "Sunday";
        const string COLD = "cold";
        const int MENU_CHOICE1 = 1;
        const int MENU_CHOICE2 = 2;
        const int MENU_CHOICE3 = 3;
        const int MENU_CHOICE4 = 4;
        public static string temp;
       
        /// <summary>
        /// Purpose: Main Entry point of program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int menuchoice = Menu();

            switch (menuchoice)
            {
                case MENU_CHOICE1:
                    IfElse();
                    break;
                case MENU_CHOICE2:
                    CaseSwitch();
                    ;
                    break;
                case MENU_CHOICE3:
                    string result =  Conditional();
                    WriteLine(result);
                    break;
                case MENU_CHOICE4:
                    WriteLine("Good-Bye!");
                    Environment.Exit(0);
                    break;
            }



            //prompt th euser to enter a day and get the input
            

            ReadKey(true);

       
    } //end Main()
        /// <summary>
        /// Purpose: A specific method for just using if-else statements.
        /// </summary>
        private static void IfElse()
        {
            Write("Please enter a day of the week, e.g. Tuesday: ");
            string today = ReadLine();

            if ((today != SUN && today != SAT))
            {
                Write("How's the weather? ");
                temp = ReadLine();
                if (temp != COLD)
                {
                    //it is a workday, display the go to work message
                    WriteLine("You have to go to work today...");
                }
                else
                {
                    WriteLine("Go to work and dress warmly");
                }
            }

            else
            {
                //it's not a workday, display the weekend message.
                WriteLine("Yeah! No work today!");

            }
            
        }
        /// <summary>
        /// Purpose: A specific method for just using switches.
        /// </summary>
        private static void CaseSwitch()
        {
            Write("Please enter a day of the week, e.g. Tuesday: ");
            string today = ReadLine();
            switch (today)
            {
                case SUN:
                    WriteLine("Yeah! No work today!");
                    break;

                case SAT:
                    WriteLine("Yeah! No work today!");
                    break;

                default:
                    WriteLine("How's the weather?");
                    string temp = ReadLine();
                    switch (temp)
                    {
                        case "cold":
                            WriteLine("Go to work and dress warmly!");
                            break;
                        default:
                            WriteLine("You have to go to work today!");
                            break;
                    }
                    WriteLine("You have to go to work today...");
                    break;
            }
        }

        /// <summary>
        /// Purporse: A specific method for just using conditional operators.
        /// </summary>
        /// <returns></returns>
        private static string Conditional()
        {
            Write("Please enter a day of the week, e.g. Tuesday: ");
            string today = ReadLine();
            return today == (SAT) || today == (SUN) ? "Yeah! It's the weekend!" : "Go to work!";
            


        }

        /// <summary>
        /// Purpose: The menu for choosing which method you want to use.
        /// </summary>
        /// <returns></returns>
        private static int Menu()
        {
            
            WriteLine("Which option would you like to try?\n");
            WriteLine("i)f-else construct");
            WriteLine("s)witch construct");
            WriteLine("c)onditional construct");
            WriteLine("q)uit Program\n");
            string choice = (ReadLine());
            switch (choice)
            {
                case "i":
                    return MENU_CHOICE1;
                case "s":
                    return MENU_CHOICE2; 
                case "c":
                    return MENU_CHOICE3;
                case "q":
                    return MENU_CHOICE4;
                default:
                    WriteLine("That wasn't an option!");
                    Menu();
                    break;
            }
            return 0;
        }

    }//end class program
}//end namespace 
