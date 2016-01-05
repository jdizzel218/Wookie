// Author: Matthew Cranford
// Assignment: Project 01
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: January 5th, 2016
// Description: This program will help someone calculate their income tax. 

//I declare that the following source code was written solely by me.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:

#1. Prompt the user to enter their taxable income.
#2. Get the input. Validate input (is a number and is a positive value), if incorrect input detected, display an error message and go back to step one.
#3. Prompt the user to enter if they are filing seperately or jointly.
#4. Validate input (is either a 's' or an 'm') if not display error message and go back to step 3.
#5. Calculate income tax using the appropriate tax table and format number into a currency type value.
#6. Output value.
#7. Ask user if they wish to do another calculation.
#8. Validate input (either a 'y' or a 'n') if y then restart the program else quit.

*/




#include <iostream>
#include <string>
using namespace std;

//This class represents taxes. It holds important data for calculating the correct income tax and has a method that will calculate the income tax for you.
class Taxes {

	//Single or Married Filing Seperate Returns
	const int SINGLE_TAXES_BRACKET_ONE = 863;
	const double SINGLE_TAX_RATE_BRACKET_ONE = .022;

	const int SINGLE_TAXES_BRACKET_TWO = 2588;
	const double SINGLE_TAX_RATE_BRACKET_TWO = .033;
	const int SINGLE_TAX_EXTRA_BRACKET_TWO = 25;


	const int SINGLE_TAXES_BRACKET_THREE = 4313;
	const double SINGLE_TAX_RATE_BRACKET_THREE = .062;
	const int SINGLE_TAX_EXTRA_BRACKET_THREE = 85;

	const double SINGLE_TAX_RATE_BRACKET_FOUR = .075;
	const int SINGLE_TAX_EXTRA_BRACKET_FOUR = 181;

	//Married Filing Joint Return
	const int MARRIED_TAX_BRACKET_ONE = 1726;
	const double MARRIED_TAX_RATE_BRACKET_ONE = .022;


	const int MARRIED_TAX_BRACKET_TWO = 5176;
	const double MARRIED_TAX_RATE_BRACKET_TWO = .033;
	const int MARRIED_TAX_EXTRA_BRACKET_TWO = 40;

	const int MARRIED_TAX_BRACKET_THREE = 8626;
	const double MARRIED_TAX_RATE_BRACKET_THREE = .062;
	const int MARRIED_TAX_EXTRA_BRACKET_THREE = 175;

	const double MARRIED_TAX_RATE_BRACKET_FOUR = .075;
	const int MARRIED_TAX_EXTRA_BRACKET_FOUR = 390;

	// Purpose: Calculates income tax.
	// Parameters: int income, char fileStatus
	// Returns: income tax as a double
	// Pre-conditions: Need input from User.
	// Post-conditions: None
	// -----------------------------------------------------------------
public:
	double CalcTax(int income, char fileStatus) {

		double tax = 0;

		if (fileStatus == 's') {
			if (income <= SINGLE_TAXES_BRACKET_ONE) {
				tax = (income)* SINGLE_TAX_RATE_BRACKET_ONE;
			}
			else if (income > SINGLE_TAXES_BRACKET_ONE && income <= SINGLE_TAXES_BRACKET_TWO) {
				tax = ((income - SINGLE_TAXES_BRACKET_ONE) * SINGLE_TAX_RATE_BRACKET_TWO) + SINGLE_TAX_EXTRA_BRACKET_TWO;
			}
			else if (income > SINGLE_TAXES_BRACKET_TWO && income <= SINGLE_TAXES_BRACKET_THREE) {
				tax = ((income - SINGLE_TAXES_BRACKET_TWO) * SINGLE_TAX_RATE_BRACKET_THREE) + SINGLE_TAX_EXTRA_BRACKET_THREE;
			}
			else if (income > SINGLE_TAXES_BRACKET_THREE) {
				tax = ((income - SINGLE_TAXES_BRACKET_THREE) * SINGLE_TAX_RATE_BRACKET_FOUR) + SINGLE_TAX_EXTRA_BRACKET_FOUR;
			}
		}
		else if (fileStatus == 'm') {
			if (income <= MARRIED_TAX_BRACKET_ONE) {
				tax = (income)* MARRIED_TAX_BRACKET_ONE;
			}
			else if (income > MARRIED_TAX_BRACKET_ONE && income <= MARRIED_TAX_BRACKET_TWO) {
				tax = ((income - MARRIED_TAX_BRACKET_ONE) * MARRIED_TAX_RATE_BRACKET_TWO) + MARRIED_TAX_EXTRA_BRACKET_TWO;
			}
			else if (income > MARRIED_TAX_BRACKET_TWO && income <= MARRIED_TAX_BRACKET_THREE) {
				tax = ((income - MARRIED_TAX_BRACKET_TWO) * MARRIED_TAX_RATE_BRACKET_THREE) + MARRIED_TAX_EXTRA_BRACKET_THREE;
			}
			else if (income > MARRIED_TAX_BRACKET_THREE) {
				tax = ((income - MARRIED_TAX_BRACKET_THREE) * MARRIED_TAX_RATE_BRACKET_FOUR) + MARRIED_TAX_EXTRA_BRACKET_FOUR;
			}
		}

		return tax;
	}

	void PrintTax(double tax) {
		cout.setf(ios::fixed);
		cout.precision(2);
		cout << "Your income tax will be: $" << tax << endl;
	}
};

// Purpose: Main Entry point into program.
// Parameters: None
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
void main() {
	Taxes taxFinder = Taxes();
	int income;
	char filingStatus;
	bool isNumber = false;
	bool marriedOrSingle = false;

	while (!(isNumber)) {
		cout << "Please enter in your taxable income." << endl << "This must be a postive value: ";
		cin >> income;

		if (income > 0) {
			isNumber = true;

			while (!(marriedOrSingle)) {
				cout << "Please enter a \"m\" if married and filing joint return,\nor an \"s\" if filing a single return: ";
				cin >> filingStatus;

				if (filingStatus == 'm' || filingStatus == 's') {
					marriedOrSingle = true;
					double tax = taxFinder.CalcTax(income, filingStatus);
					taxFinder.PrintTax(tax);
				}
				else {
					cin.clear();
					cout << "You have entered an incorrect choice.\nPlease choose either [s]ingle or [m]arried";

				}
			}

		}
		else {
			cout << "You have entered in a number that's less than zero." << endl;
		}
	}
	

	system("pause");


}
