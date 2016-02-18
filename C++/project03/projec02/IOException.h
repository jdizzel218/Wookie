// Author: Matthew Cranford
// Assignment: Project 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written:  Feb 7 2016
// Description: IOException definition


#pragma once
#ifndef IOException_H
#define IOException_H


#include <stdexcept>

using namespace std;


const int EOF_ERR = 1;
const int READ_ERROR = 2;
const int CANT_OPEN_File = 3;


class IOException : exception 
{
public:

	// Purpose: Default Constructor
	// Parameters: None
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	IOException();

	// Purpose: Parameterized constructor
	// Parameters: string error message, value
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	IOException(string errMsg, int value);

	// Purpose: Gets the error message.
	// Parameters: None
	// Returns: Error Message
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	string getErrorMessage() const;

private:

	string _message;

	int _value;

};



#endif // !IOException_H
