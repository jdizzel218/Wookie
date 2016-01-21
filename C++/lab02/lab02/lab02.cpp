// Author: Matthew Cranford
// Assignment: Lab 02
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 12th 2016
// Description: Sums decimals numbers provided by user.

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:
#1. Create a vector of doubles, and an array of 5.
#2. Write a loop that prompts for user to input value, sanitize value (can't be less than zero, or greater than one, and has to be a decimal)
#3. Write a loop that copies all elements of vector into the array.
#4. Write a function that sums all the elements of the array.
#5. Output sum up to 2 decimal places.
*/


#include <iostream>
#include <vector>

using namespace std;

const int SIZE = 5;
const int MAX = 80;

// Purpose: Sums all decimals in an array.
// Parameters: double anArray[]
// Returns: Sum
// Pre-conditions: The User to enter in decimal values.
// Post-conditions: None
// -----------------------------------------------------------------
double Sum(double anArray[]) {

	double sum = 0;

	for (int i = 0; i < SIZE; i++) {

		sum += anArray[i];
	}

	return sum;
}

// Purpose: Main entry point into program
// Parameters: None
// Returns: 0 if program runs correctly with no errors
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int main() {

	int sentinel = 0;
	double input = 0;

	vector<double> myVector;
	double myArray[SIZE] = { 0 };

	cout << "Please enter in a decimal value: " << endl;

	do {

		cin >> input;

		if (!(cin)) {
			cout << "Invalid Input: Please enter in a decimal value" << endl;
			cin.clear();
			cin.ignore(MAX, '\n');
		}
		else if (input < 0) {
			cout << "Invalid Input: Please enter a postive number" << endl;
		}
		else if (input >= 1) {
			cout << "Invalid Input: Please enter a decimal value" << endl;
		}

		else {
			myVector.push_back(input);
			sentinel++;
		}

	} while (sentinel < SIZE);

	//Add all numbers from vector into array
	for (int i = 0; i < SIZE; i++) {
		myArray[i] = myVector[i];
	}

	//Sum the array.
	double sum = Sum(myArray);

	//Display output to two decimal places.
	cout.setf(ios::fixed);
	cout.precision(2);

	//Output
	cout << "The sum of all the decimals is: " << sum << endl;

	system("pause");

	return 0;
} // End main()



