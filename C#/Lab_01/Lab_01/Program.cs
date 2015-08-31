// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_01
// Date: 8/25/2015 10:01:27 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using static System.Console;

namespace Lab_01
{
    static public class Program
    {
        /// <summary>
        /// Purpose: Entry point to my C# program
        /// </summary>
        static public void Main()
        {
            //This code stores my student information in string variables
            string name = "Matthew Cranford";
            string course = "CS 1400";
            string section = "001/002";
            string project = "Lab One";

            //This code displays the strings above, on the console
            WriteLine("Name: {0}", name);
            WriteLine("Course: {0}", course);
            WriteLine("Section: {0}", section);
            WriteLine("Project: {0}", project);

            //This code freezes the Console until the Enter Key is pressed
            WriteLine("Press Enter to continue...");
            ReadKey(true);
            
        }//End Main()
    }//End class Program
}//End namespace Lab_01

