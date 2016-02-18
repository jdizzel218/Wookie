// Author: Matthew Cranford
// Assignment: Project 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written:  Feb 7 2016
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

#ifndef Author_H
#define Author_H

#include <string>
#include <fstream>
#include "IOException.h"
using namespace std;

class Author
{

public:
	// Purpose: Default Constructor
	// Parameters: None
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	Author();
	
	// Purpose: Parameterized Construcor
	// Parameters: string name string address
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	Author(const string& name, const string& address);
	// Purpose: Gets the authors name
	// Parameters: None
	// Returns: Authors name
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	string getName() const;
	// Purpose: Gets the authors address
	// Parameters: None
	// Returns: authors addresss
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	string getAddress() const;

	// Purpose: Sets the authors Address
	// Parameters: string address 
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	void setAddress(string address);

	// Purpose: Sets Author name
	// Parameters: string name
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	void setName(string name);

	// Purpose: Reads data from file.
	// Parameters: ifstream object
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	void readData(ifstream& in);


	// Purpose: Writes book data out to txt file.
	// Parameters: ofstream object.
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	void writeData(ofstream& out);

private:
	string _name;
	string _address;


};
#endif