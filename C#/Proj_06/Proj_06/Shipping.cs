using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double total = Category * NumItems + Surcharge;
            return total;
        }
    }
}
