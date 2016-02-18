// Author: Matthew Cranford
// Assignment: Project 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written:  Feb 7 2016
// Description: IOException implementation.


#include "IOException.h"


// Purpose: Default Constructor
// Parameters: None
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
IOException::IOException()
{

	_message = "None";
	_value = 0;


}

// Purpose: Parameterized Constructor
// Parameters: string Error message, int value
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
IOException::IOException(string errMsg, int value)
{

	_message = errMsg;
	_value   = value;

}

// Purpose: Gets Error Message
// Parameters: None
// Returns: string error message.
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
string IOException::getErrorMessage() const { return _message; } 