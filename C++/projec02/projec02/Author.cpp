// Author: Matthew Cranford
// Assignment: Project 02
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 22th 2016
// Description: Author Class Definition

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:
#1. Create a Author Class that includes the authors name and address
#2. Create a Book Class that includes the title, number of pages and the price
#3. Write the code in the display books method that outputs all the class data (title, author, number of pages, price)
*/
#include<string>
#include "Author.h"

using namespace std;

// Purpose: Default Constructor
// Parameters: None
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
Author::Author() 
{

	_name = "None";
	_address = "None";
}
// Purpose: Parameterized Construcor
// Parameters: string name string address
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
Author::Author(const string& name, const string& address)
{
	_name = name;
	_address = address;
}
// Purpose: Gets the authors name
// Parameters: None
// Returns: Authors name
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
string Author::GetAuthorName() const { return _name; }
// Purpose: Gets the authors address
// Parameters: None
// Returns: authors addresss
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
string Author::GetAuthorAddress() const { return _address; }
