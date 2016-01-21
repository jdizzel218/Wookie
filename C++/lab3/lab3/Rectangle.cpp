// Author: Matthew Cranford
// Assignment: Lab 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 13th 2016
// Description: Rectangle Class

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

//This class holds all the necessary functions for a rectangle. You can get the height, width, or the area.
class Rectangle
{
	int _height = 0;
	int _width = 0;

public:
	// Purpose: Constructor for Class
	// Parameters: length and width
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: sets class level variables
	// -----------------------------------------------------------------
	 Rectangle(int length, int width)
	{
		_height = length;
		_width = width;
	}

	 // Purpose: Gets the height of the object
	 // Parameters: None
	 // Returns: Height
	 // Pre-conditions: None
	 // Post-conditions: None
	 // -----------------------------------------------------------------
	int getHeight() 
	{
		return _height;
	}
	// Purpose: Gets the width of the object
	// Parameters: None
	// Returns: Width
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int getWidth()
	{
		return _width;
	}

	// Purpose: Get Area of the object
	// Parameters: None
	// Returns: area
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int getArea() {

		int area = _height * _width;
		return area;
	}


};