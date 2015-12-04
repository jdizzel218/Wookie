
/*
Pseudo-Code:

#1. Take input from usere -> first name and bowling score on single line.
#2. Use the Split method to parse the input, the name goes in an array of strings, and the score in an array of ints
#3. If the user enters an empty line, then quit adding users and scores to the arrays.
#4. Output the users and scores. Output the highest score, the lowest score and the average score.


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BowlingScores1
{
    class BowlTeam
    {

        int[] _scores;
        string[] _names;

        string[] _userInputParsed;
        public int HigestScore{get;set;} 
        public int LowestScore { get; set; }

        public int AverageScore { get; set; }
       
        public void GetData()
        {
            string userInput;
            do {

                WriteLine("Enter the Name and Score seperated by a comma, i.e -> Frank,86");
                userInput = ReadLine();
                _userInputParsed = userInput.Split(',');
               
            } while (userInput.Length > 0);



            for(int i = 0; i < 10; i++)
            {
                _names[i] = _userInputParsed[0];
                _scores[i] = _userInputParsed[1];
            }

        }
        static int CalcHighestScore()
        {
            return 0;
        }

        static int CalcLowestScore()
        {
            return 0;
        }

        static int CalcAverageScore()
        {
            
            return 0;
        }

    }
}
