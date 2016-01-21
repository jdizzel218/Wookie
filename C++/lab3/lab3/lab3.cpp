// Author: Matthew Cranford
// Assignment: Lab 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 13th 2016
// Description: Display area of rectangle

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:
#1. Create a class called Rectangle with a paratermized constructor.
#2. Pass in a height of 4 and a length of 7 into the constructor
#3. Output the area and width and heigth using the objects getArea(), getHeight(), getWidth() functions.
*/

#include <iostream>
#include "Rectangle.cpp"

using namespace std;


// Purpose: Main entry point into program.
// Parameters: None
// Returns: 0 if program exits without any errors.
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int main()
{
	int height = 4;
	int width = 7;

	Rectangle rect = Rectangle(height, width);


	cout << "Height: " << rect.getHeight() << endl;

	cout << "Width: " << rect.getWidth() << endl;

	int area = rect.getArea();

	cout << "Area of the rectangle is: " << area << endl;
	
	system("pause");

	return 0;
}//End Main