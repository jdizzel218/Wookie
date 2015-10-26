// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_10
// Date: 10/12/2015 9:37 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab_10
{
    static public class Program
    {
        /// <summary>
        /// Purpose: Main Entry point of program.
        /// Parameters: None
        /// Returns: None
        /// </summary>
        static public void Main()
        {
            /*
            Psedo-Code
            1. Ask the user to enter the length of one side of a right triangle.
            2. Get the user's input and save it in an appropriate variable.
            3. Ask the user to enter the lengt of the other side of the triangle.
            4. Get the user's input and save it in an appropriate variable.
            5. Call the CalcHypotenuse method and pass it the lengths of the two sides of the triangle as arguments.
            6. Save the value returned by the method in an apporpriate variable.
            7. Properly label and dispaly the value returned by the method.

            */
            double side1;
            double side2;
            double hypotenuse;
            Write("Please enter a number for the first side of the Triangle: ");

            if (double.TryParse(ReadLine(), out side1))
            {
                Write("Please enter a number for the second side of the Triangle: ");
                if (double.TryParse(ReadLine(), out side2))
                {
                    hypotenuse = CalcHypotenuse(side1, side2);
                    
                    

                    WriteLine("The length of the Hypotenuse is: {0}.\n", hypotenuse.ToString("#.##"));
                    
                }
                else
                {
                    WriteLine("The value you entered is incorrect. Please enter a number. You will start over.\n");
                    Main();
                }
            }
            else
            {
                WriteLine("The value you entered is incorrect. Please enter a number.\n");
                Main();
            }


            Write("Press any key to continue ... ");
            ReadKey(true);
        }//End Main()

        /// <summary>
        /// Purpose: Calculates the hypotenuse of a triangle.
        /// Parameters: side1 and side2
        /// Returns: double hypotenuse.
        /// </summary>
        /// <param name="side1">User input</param>
        /// <param name="side2">User Input</param>
        /// <returns></returns>
        static double CalcHypotenuse(double side1, double side2)
        {
            double hypotenuse;
            /*
            Pseudo-Code
            1. Take user input for side1 and side2.
            2. Call Math.Sqr on side1 and side2 and then add them together.
            3. Then call Math.Sqrt on the resultant.
            4. return resultant.
            */

             hypotenuse = Math.Sqrt(((side1)*(side1)) + ((side2) * (side2)));

            return hypotenuse;
        }
    }//End class Program


    //Question #1: Methods are useful because we can create small REUSABLE parts of code that we can use throughout the program. They also break big problems into smaller ones.
    //Question #2: Because sometimes the data we need to work with changes throughout the program, so it's useful to have a method that can work with whatever we pass it.

}//End namespace Lab_10

