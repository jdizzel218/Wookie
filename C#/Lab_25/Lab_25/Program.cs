

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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Lab_25
{
    class Program
    {
        
        const int SIZE = 50;
        int[] _grades = new int[SIZE];
        static void Main(string[] args)
        {
            
        }



        public void GetData()
        {
            int grades;
            string file = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\grades.txt";
            StreamReader gradeFile = new StreamReader(file);


            do
            {
                grades = int.Parse(gradeFile.ReadLine());


            } while (grades != null);
            
        }
       public int CalcGradeAverage(int[] grades)
        {


            return 0;
        }
    }
}
