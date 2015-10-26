// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_13
// Date: 10/21/2015 9:16 AM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Pseudo-Code

1. Create a class called TokenMachine
2. Add fields of NumQuarters and NumTokens,
3. Create properties to get the class fields
4. Create methods for resetting the tokens & quarters && for incrementing and decrementing the quarters and tokens.
5. Create event handlers to call the TokenMachine class methods. (specifically reset() and getToken())


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenMachine
{
    class TokenMachine
    {

        private int _numTokens;
        private int _numQuarters;

        /// <summary>
        /// Purpose: Makes class level variable public
        /// </summary>
        public int CountTokens { get { return _numTokens; } }
        /// <summary>
        /// Purpose: Makes class level variable public
        /// </summary>
        public int CountQuarters{get { return _numQuarters; } }
        /// <summary>
        /// Purpose: Makes class level variable public
        /// </summary>

        public int TokensDispensed { get { return _numQuarters; } }

        /// <summary>
        /// Purpose: Class Constructor
        /// </summary>
        public TokenMachine()
        {
            _numTokens = 100;
            _numQuarters = 0;
        }

        /// <summary>
        /// Purpose: Resets the variables when called.
        /// </summary>
        public void Reset()
        {
            _numTokens = 100;
            _numQuarters = 0;
            
        }

        /// <summary>
        /// Purpose: Dispenses Tokens when called.
        /// </summary>
        public void GetToken()
        {
            _numTokens -= 1;
            _numQuarters += 1;

            

        }

    }
}
