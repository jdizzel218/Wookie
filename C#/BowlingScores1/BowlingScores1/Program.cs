//File Prologue


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

namespace BowlingScores1
{
    class Program
    {
        static void Main(string[] args)
        {
            BowlTeam bowling = new BowlTeam();

            bowling.GetData();
            bowling.ParseData();
        }


        static void Menu()
        {

        }
    }
}
