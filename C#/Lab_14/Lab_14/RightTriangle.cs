﻿// File/Project Prolog
// Name: Matthew Cranford
// CS 1400 Section 001
// Project: Lab_14
// Date: 10/28/2015 2:25 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

/*

Pseudo-Code:

1. Create a class for a right Triangle.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class RightTriangle
    {
        
        const double _ANGLE = 90;
        const int AREA_FORMULA = 2;

        /// <summary>
        /// Purpose: Gets or Sets the variable _sideA
        /// </summary>
        public double SideA
        {
            get; set;
        }
        /// <summary>
        /// Purpose: Gets or Sets the variable _sideB
        /// </summary>
        public double SideB
        {
            get; set;
        }

        /// <summary>
        /// Purpose: Calculates the hypontenuse.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <returns></returns>
        public double CalcHypotenuse()
        {
            //This is where you use the pythagreom theorem to calculate the hypontenuse
            // a^2 * b^2 = c^2
            double hyp = Math.Sqrt((SideA * SideA) + (SideB * SideB));
            return hyp; //Return the hypontenuse.
        }

        /// <summary>
        /// Purpose: Calculates the area of the triangle.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double CalcArea()
        {
            // calculate the area of the triangle.
            // Using this formula: A = height * length / 2

            double area = (SideA * SideB) / AREA_FORMULA;

            return area;
        }

        

    }
}
