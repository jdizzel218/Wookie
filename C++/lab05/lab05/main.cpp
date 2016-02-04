// Author: Matthew Cranford
// Assignment: Lab 5
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: Feburary 3rd 2016
// Description: Main

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:

#1.Declare an integer value to store the user's input.
#2.Prompt the user to enter a positive, non-zero integer value.
#3.Pass this value to a function named calculateSquare.
#4.This function will only work on positive, non-zero values. Since the function has no idea where the data came from it has no way to recover if the parameter it receives is invalid.
#5.If the value passed is zero or negative the function will throw an exception that (1) indicates what the error was, and (2) what the value of the offending parameter is.
#6.If the parameter is okay, it calculates and returns the square of the number.

*/


#include "LessThanZero.h"
#include <iostream>

using namespace std;


// Purpose: Parameterized Construcor
// Parameters: string name string address
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int calculateSquare(int userInput) {

	if (userInput < 0) {

		throw LessThanZeroError("Invalid Input. The number is less than zero", userInput);
	}
	else if (userInput == 0) {

		throw LessThanZeroError("Invalid Input. The number is equal to zero.", userInput);
	}
	else {

		int square = (userInput * userInput);
	}

}


// Purpose: Parameterized Construcor
// Parameters: string name string address
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int main() {

	int usrInput = 0;

	try {
		cout << "Please enter in a positive, non-zero number: ";

		cin >> usrInput;

		int square = calculateSquare(usrInput);

		cout << "The Square of that number is: " << square << endl;

		system("pause");
	}

	catch (LessThanZeroError e) {

		 cout << "Program encountered an error: " << e.getReason() << endl;
		 cout << "Value that caused the error: " << e.getValue() << endl;

		 system("pause");
	}

	return 0;
}