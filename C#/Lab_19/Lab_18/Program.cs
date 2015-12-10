// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_19
// Date: 11/6/2015 2:10 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code:

#1. Ask User if they want to roll the dice.
        -if No then quit
#2. Get user response, make sure the input is valid (either a yes, y, ye, or a no, n)
#3. Simulate a pair of dice by creating a random object and passing it 1 & 6. (i.e random.Next(1,6))
#4. If it returns 2 6's, then display: "you rolled boxcars", else: Display output amd return back to step one.
#5. If it returns 2 1's then display: "You rolled snake-eyes" else: display the output and return back to step one.
#6. default: Display: "You rolled... X & X" <<-- replace with numbers
#7. Return back to step 1 and ask the user if the want to roll the dice

Do this all in a Do-While loop.

*/

using System;

namespace Lab_18
{
    class Program
    {
        
        /// <summary>
        /// Purpose: Main Entry point of program, simulates rolling a pair of dice. Outputs reponse to user.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create objects

            Random random = new Random();

            //Class level Consts

            const int HIGHEST_VALUE = 7;
            const int LOWEST_VALUE = 1;

            const int rolledSix = 6;
            const int rolledOne = 1; // a different const for this one to make the code easier to read. So as not to confuse the programmer.

            do
            {
                Console.WriteLine("Do you want to roll the dice?");
                string response = Console.ReadLine().ToLower();

                if (response.StartsWith("y"))
                {
                    int diceOne = random.Next(LOWEST_VALUE,HIGHEST_VALUE);
                    int diceTwo = random.Next(LOWEST_VALUE, HIGHEST_VALUE);


                    if (diceOne == rolledSix && diceTwo == rolledSix)
                    {
                        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}");
                        Console.WriteLine("You rolled boxcars!\n");
                    }
                    else if (diceOne == rolledOne && diceTwo == rolledOne)
                    {
                        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}");
                        Console.WriteLine("You rolled snake-eyes!\n");
                    }
                    else
                    {
                        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}\n");
                    }
                }
                else if(response.StartsWith("n"))
                {
                    Console.WriteLine("Good Bye!");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You have entered a invalid input. Please enter either a [y]es or a [n]o.\n");
                }

            } while (true);

            
        }
    }
}
