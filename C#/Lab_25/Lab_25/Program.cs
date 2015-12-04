// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_25
// Date: 12/4/2015 3:30 PM

// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------


/*
Pseudo-Code:
#1. Create an int array of size 50.
#2. Have the program get the path to the User's Documents Folder.
#3. Create a StreamReader object with the path from step #2.
#4. Loop through the files until it discovers the end of the file.
#5. As each int is read, store it in the array.
#6. Write a method that takes an array as a parameter, that calculates and returns the average value of the arrays.
#7. Output the average.
*/

using System;
using static System.Console;
using System.IO;

namespace Lab_25
{
    class Program
    {
        
        const int SIZE = 50;
        static int[] _grades = new int[SIZE];
        /// <summary>
        /// Purpose: Main Entry 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Input from \'Grades.txt\':");
            WriteLine("========================\n");
            int counter = GetData();
            int average = CalcGradeAverage(_grades,counter);


            WriteLine($"\nThe average grade is: {average}.");

            ReadKey(true);
        }

        /// <summary>
        /// Purpose: Reads the data from the txt file and stores it in an array.
        /// </summary>
        /// <returns></returns>
        static public int GetData()
        {
            string grades = "";
            int counter = 0;
            
            string file = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\grades.txt";
            StreamReader gradeFile = new StreamReader(file);

            do
            {

                grades = gradeFile.ReadLine();
                if (!string.IsNullOrEmpty(grades))
                    _grades[counter] = int.Parse(grades);
                else
                    break;

                
                WriteLine(_grades[counter]);
                counter++;


            } while (grades != null);

            return counter;

        }

        /// <summary>
        /// Purpose: Calculates the average score by diving the sum of the grades by the number of grades.
        /// </summary>
        /// <param name="grades"></param>
        /// <param name="arrayLength"></param>
        /// <returns></returns>
        static public int CalcGradeAverage(int[] grades, int arrayLength)
        {
            int average = 0;
            for (int i = 0; i <= arrayLength; i++)
            {
                average += grades[i];
            }
            average = average / arrayLength;
            return average;
        }
    }
}
