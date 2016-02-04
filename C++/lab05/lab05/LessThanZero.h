// Author: Matthew Cranford
// Assignment: Lab 5
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: Feburary 3rd 2016
// Description: LessThanZero Exception Definition


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



#pragma once

#ifndef LessThanZero_H
#define LessThanZero_H

#include <exception>
#include <stdexcept>
#include <string>

using namespace std;
class LessThanZeroError : public exception
{

public:

	// Purpose: Parameterized Construcor
	// Parameters: string name string address
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	LessThanZeroError();

	// Purpose: Parameterized Construcor
	// Parameters: string name string address
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	LessThanZeroError(string reason, int value);


	// Purpose: Parameterized Construcor
	// Parameters: string name string address
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	string getReason() const;

	// Purpose: Parameterized Construcor
	// Parameters: string name string address
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int getValue() const;

private:
	string _reason;

	int _value;

};


#endif