// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_06
// Date: 11/3/2015 2:25 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------


/*
Pseudo-Code:

1. Get Input from user regarding Shipping Method, How the want to ship (category - by weight or by items) and how many items and whether they are shipping to AL or HA
2. Create a class that will store that data and perform the calculation of the shipping - total = number of items * category + surcharge, then base that total of what type of shipping method they are using.
3. Output that total back to the user in a easy to read format.
*/

namespace Proj_06
{
    class Shipping
    {
        
        /// <summary>
        /// Purpose: Property value for the Method of Shipping.
        /// </summary>
        public string ShipMethod
        {
            get; set;
        }
        /// <summary>
        /// Purpose: Property value for Category A
        /// </summary>
        public double Category
        {
            get; set;
        }
        /// <summary>
        /// Purpose: Property value for Number of items.
        /// </summary>
        public int NumItems
        {
            get; set;
        }
        /// <summary>
        /// Purpose: Property for whether there is a surcharge or not.
        /// </summary>
        public double Surcharge
        {
            //property for setting if there is a surcharge or not
            get; set;
        }
        /// <summary>
        /// Purpose: Calculates Shipping 
        /// </summary>
        /// <returns></returns>
        public double CalcShipping()
        {

            //Calculates the shipping from all the variables
            double total = (Category * NumItems) + Surcharge;
            return total;
        }
    }
}
