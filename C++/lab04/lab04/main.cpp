// Author: Matthew Cranford
// Assignment: Lab 04
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 24th 2016
// Description: Reads voltages from a .txt file and calculates the average.

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:
#1. Create an array of doubles that can hold up to 100 elements.
#2. Open up the 'voltages.txt' file, it should work for any number in the file up to 100 values.
#3. Verify that the file was sucessfully opened.
#4. Read voltage values from file and store them in the array. Test the stream after each read operation to make sure that it worked.
#5. Calculate the average voltage value and display it.
*/


#include <iostream>
#include <fstream>

using namespace std;




// Purpose: Finds the average of the doubles in an array.
// Parameters: double anArray[], int sentinel
// Returns: average
// Pre-conditions: An array of doubles and how many are inside the array.
// Post-conditions: None
// -----------------------------------------------------------------
double CalcVoltAvg(double voltages[], int sentinel) {

	double average = 0;

	for (int i = 0; i < sentinel; i++) {
		average += voltages[i];


	}
	average = average / sentinel;
	return average;

}

// Purpose: Main Entry Point into Program
// Parameters: None
// Returns: 0 if everything worked correctly.
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int main() {

	const int MAX_SIZE = 100;

	double volts[MAX_SIZE] = { 0 };
	int sentinel = 0;

	ifstream voltages("voltages.txt");

	if (voltages.fail()) {

		cout << "File failed to open." << endl;
	}
	else {

		cout << "The file was opened successfully." << endl;
		cout << "The voltages in the file are:\n";

		int anotherSentinel = 0;


		while (voltages >> volts[anotherSentinel] && voltages.good()) { //Check for eof and to make sure the stream is good.
			cout << volts[anotherSentinel] << endl;
			sentinel++;
			anotherSentinel++; //This is a sentinel so that you don't need to use a for loop.
		}

		double avg = CalcVoltAvg(volts, sentinel);
		cout << "The average is: " << avg << endl;

	}

	cout << "\n\n";
	system("pause");
	return 0;
}