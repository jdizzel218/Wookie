// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Proj_05
// Date: 10/30/2015 1:48 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*
Psedo-Code:
1. Create a SalesInvoice object
2. Store the values entered by the user in that object using appropriate methods.
3. Use Methods to calculate the state and local tax, net sales value and gross sales value, state and local tax are: 7.45% and 2.5% respectively.
4. Display an invoice back to the user using a messagebox.
*/

namespace Proj_05
{
    class SalesInvoice
    {
        const double STATE_TAX = .0745;
        const double LOCAL_TAX = .025;

        /// <summary>
        /// Purpose: Sets and Gets the NumItems property.
        /// </summary>
        public double NumItems
        {
            get; set;
        }

        /// <summary>
        /// Purpose: Gets and Sets the UnitPrice property.
        /// </summary>
        public double UnitPrice
        {
            get; set;
        }

        /// <summary>
        /// Purpose: Calculates the net sale price
        /// </summary>
        /// <returns></returns>
        public double CalcNetSales()
        {
            double netSale = NumItems * UnitPrice;
            //net sales = NumItems * Unit Price.
            return netSale;
        }

        /// <summary>
        /// Purpose: Calculates the state tax.
        /// </summary>
        /// <returns></returns>
        public double CalcStateTax()
        {
            //State Tax = net sale * state tax (7.45%)
            double stateTax = CalcNetSales() * STATE_TAX;
            
            return stateTax;
        }

        /// <summary>
        /// Purpose: Calculates the Local Tax.
        /// </summary>
        /// <returns></returns>
        public double CalcLocalTax()
        {
            //Local tax = net sale * local tax (2.5%)
            double localTax = CalcNetSales() * LOCAL_TAX;
            return localTax;
        }

        /// <summary>
        /// Purpose: Calculates the Gross Sale price.
        /// </summary>
        /// <returns></returns>
        public double CalcGrossSale()
        {
            // gross sale = Net sale + state tax + local tax.
            double grossSale = CalcNetSales() + CalcStateTax() + CalcLocalTax(); 
            return grossSale;
        }

    }
}
