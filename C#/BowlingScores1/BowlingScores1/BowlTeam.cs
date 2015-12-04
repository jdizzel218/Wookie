
/*
Pseudo-Code:

#1. Take input from user -> first name and bowling score on single line.
#2. Use the Split method to parse the input, the name goes in an array of strings, and the score in an array of ints
#3. If the user enters an empty line, then quit adding users and scores to the arrays.
#4. Output the users and scores. Output the highest score, the lowest score and the average score.


*/


using System;
using static System.Console;

namespace BowlingScores1
{
    class BowlTeam
    {
        const int ARRAY_SIZE = 10;

        string[] _scores = new string[ARRAY_SIZE];
        string[] _names = new string[ARRAY_SIZE];
        string[] _userInputParsed;

        
        public int HigestScore{get;set;} 
        public int LowestScore { get; set; }

        public int AverageScore { get; set; }
       
        public  void GetData()
        {
            string userInput;
            do {

                WriteLine("Enter the Name and Score seperated by a comma, i.e -> Frank,86");
                userInput = ReadLine();
                _userInputParsed = userInput.Split(new char[]{','});
               
            } while (userInput.Length > 0);

        }

        public void ParseData()
        {
            for (int i = 1; i < 10; i++)
            {

                _names[0]  = _userInputParsed[0];
                _names[i]  = _userInputParsed[i + 2];
                Console.WriteLine($"{_names[0]}");
                Console.WriteLine($"{_names[i]}");

            }

            for (int i = 1; i < ARRAY_SIZE; i++)
            {
                _scores[0] = _userInputParsed[1];
                _scores[i] = _userInputParsed[i + 2];

                Console.WriteLine($"{_scores[0]}");
                Console.WriteLine($"{_scores[i]}");
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
            //for(int i = 0; i < _)
            return 0;
        }

    }
}
