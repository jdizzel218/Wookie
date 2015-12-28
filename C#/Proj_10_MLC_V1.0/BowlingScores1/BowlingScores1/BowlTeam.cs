// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_09
// Date: 12/14/2015 12:45 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:

#1. Take input from user -> first name and bowling score on single line.
#2. Use the Split method to parse the input, the name goes in an array of strings, and the score in an array of ints
#3. If the user enters an empty line, then quit adding users and scores to the arrays.
#4. Calculate the highest score by keeping track and comparing the index of the highest score. Do this for the low score.
#5. Calculate the average by adding all of the scores together and diving by the total scores.
#6. Output the users and scores. Output the highest score, the lowest score and the average score.

*/


using System;
using static System.Console;

namespace BowlingScores1
{
    class BowlTeam
    {
        const int ARRAY_SIZE = 10;
        const int PERFECT_SCORE = 300;
        const int USER_INPUT = 2;

        int[] _scores = new int[ARRAY_SIZE];
        string[] _names = new string[ARRAY_SIZE];
        int count = 0;

        /// <summary>
        /// Purpose: Gets data from User
        /// </summary>
        public void GetData()
        {
            WriteLine("Enter to 10 Name and Score seperated by a comma, i.e -> Frank,86");
            WriteLine("When you are done, Press 'Enter'.\n");
            string userInput;

            do
            {

                userInput = ReadLine();
                if (userInput.Length > 0 && userInput.Split(',').Length == USER_INPUT)
                {

                    if (ParseLine(userInput, count))
                    {
                        count++;
                    }
                }

            } while (userInput.Length > 0 && count < ARRAY_SIZE);

        }

        /// <summary>
        /// Purpose: Parses the data into the appropriate array.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="index"></param>
        private bool ParseLine(string line, int index)
        {


            var items = line.Split(',');
            var name = items[0];
            var score = items[1];
            _names[index] = name;
            if (int.TryParse(score, out _scores[index]) && _scores[index] > 0 && _scores[index] <= PERFECT_SCORE)
            {
                return true;
            }
            else
            {
                _names[index] = null;
                _scores[index] = 0;
                WriteLine("You have entered in a bad input. Please try again.");
                return false;

            }
        }
        /// <summary>
        /// Purpose: Calculates the highest, lowest and average score by keeping a count of the index. If the index of the count is greater than the index of i for all iterations then the index of the count will be the highest score. I can use that index to find the name associated with the higest score.
        /// </summary>
        /// <returns></returns>
        public void FindScore()
        {
            //Keep track of the indexes.
            int sum = 0;
            int lowScoreIndex = 0;
            int highScoreIndex = 0;

            for (int i = 0; i < count; i++)
            {
                if (_scores[i] > _scores[highScoreIndex])
                {

                    highScoreIndex = i;
                }

                if (_scores[i] < _scores[lowScoreIndex])
                {
                    lowScoreIndex = i;
                }

                sum = sum + _scores[i];
            }

            //Calc the average.
            int average = sum / count;


            //Output to user.
            WriteLine($"\nHighest Score: {_names[highScoreIndex]} with {_scores[highScoreIndex]}\nLowest  Score: {_names[lowScoreIndex]} with {_scores[lowScoreIndex]}\nAverage Score: {average}");

        }

        /// <summary>
        /// Purpose: Displays the bowlers and their scores to the user.
        /// </summary>
        public void Bowlers()
        {
            WriteLine("Bowlers\tScores");
            WriteLine("======= =======");
            for (int i = 0; i < count; i++)
            {

                WriteLine($"{_names[i]}\t{_scores[i]}");
            }
        }

        /// <summary>
        /// Purpose: Bubble Sorts the Bowlers in Decending order (from greatest to smallest)
        /// </summary>
        public void SortBowlers()
        {
            WriteLine("\nSorted Bowlers");
            WriteLine("==============\t=======");

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count; i++)
                {
                    if (_scores[i] < _scores[i + 1])
                    {
                        Swap(ref _scores[i], ref _scores[i + 1]);
                    }
                }

                if (_scores[j] == PERFECT_SCORE)
                {
                    WriteLine($"*{_names[j]}\t{_scores[j]}");
                }
                else
                {
                    WriteLine($"{_names[j]}\t{_scores[j]}");
                }
            }
        }

        /// <summary>
        /// Purpose: Swaps numbers x and y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
