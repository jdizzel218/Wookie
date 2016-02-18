// Author: Matthew Cranford
// Assignment: Project 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written:  Feb 7 2016
// Description: Book Class Definition

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

#pragma once

#ifndef Book_H
#define Book_H
#include "Author.h"
#include "IOException.h"
#include <fstream>
using namespace std;


class Book
{
public:
	// Purpose: Default Constructor
	// Parameters: None
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	Book();


	// Purpose: Parameterized Constructor
	// Parameters: Author object, string title, int number of pages, double price
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	Book(const Author &, const string &, int, double);


	// Purpose: Returns the books author
	// Parameters: None
	// Returns: Author's name
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	string getAuthor() const;


	// Purpose: Get Book title
	// Parameters: None
	// Returns: authors name.
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	string getTitle() const;


	// Purpose: Get Number of pages
	// Parameters: None
	// Returns: title
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int getNumPages() const;


	// Purpose: Get the price of the book
	// Parameters: None
	// Returns: book price
	// Pre-conditions: The User to enter in decimal values.
	// Post-conditions: None
	// -----------------------------------------------------------------
	double getPrice() const;

	string getAddress() const;

	void readData(ifstream& in);


	void writeData(ofstream& out);

private:
	Author _author;
	string _title;
	int _numPages;
	double _price;
	
	const int READ_ERROR = 2;
};
#endif