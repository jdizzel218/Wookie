

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
#include <vector>

using namespace std;


const int SIZE = 5;


int main() {

	
	const int MAX = 80;
	bool sentinel = false;
	vector<double> myVector;

	double myArray[SIZE] = { 0 };
	if (!(cin)) {

		cout << "Invalid input. Please try again." << endl;
		myVector[i] = 0;
		cin.clear();
		cin.ignore(MAX, '\n');
	}











	return 0;
} // End main()


int addToVector(vector<double> aVector) {

	int elementsInVector = 0;
	for (int i = 0; i < SIZE; i++) {

		cout << "Please enter in a decimal value: ";
		cin >> aVector.push_back[i];
		elementsInVector++;
	}// end for loop

	return elementsInVector; //return how many items are actually in vector
}