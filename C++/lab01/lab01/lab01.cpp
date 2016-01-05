// Author: Matthew Cranford
// Assignment: Lab 01
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 5th, 2016
// Description: My First C++ program

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


#include <iostream>
#include <string>

using namespace std;

// Purpose: Main Entry point into program.
// Parameters: None
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int main() {

	string name;
	string end;
	cout << "Hello, my name is Hal, what is your name?" << endl;
	getline(cin, name);
	cout << "Welcome to C++ " << name <<", let the adventure begin!";

	getline(cin, end);
	cout << "Good-Bye!";
	
}

