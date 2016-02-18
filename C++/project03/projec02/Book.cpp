// Author: Matthew Cranford
// Assignment: Project 03
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written:  Feb 7 2016
// Description: Book Class Implementation

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

#include<string>
#include "Book.h"
using namespace std;

// Purpose: Default Constructor
// Parameters: None
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
Book::Book()
{

	_title = "None";
	_numPages = 0;
	_price = 0.0;
}

// Purpose: Parameterized Constructor
// Parameters: Author object, string title, int number of pages, double price
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
Book::Book(const Author& author, const string& title, int numberOfPages, double price)
{
	this->_author = author;
	_title = title;
	_numPages = numberOfPages;
	_price = price;

}


// Purpose: Returns the books author
// Parameters: None
// Returns: Author's name
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
string Book::getAuthor() const { return _author.getName(); }



// Purpose: Get Book title
// Parameters: None
// Returns: authors name.
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
string Book::getTitle() const { return _title; }



// Purpose: Get Number of pages
// Parameters: None
// Returns: title
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int Book::getNumPages() const { return _numPages; }



// Purpose: Get the price of the book
// Parameters: None
// Returns: book price
// Pre-conditions: The User to enter in decimal values.
// Post-conditions: None
// -----------------------------------------------------------------
double Book::getPrice()const { return _price; }


// Purpose: Get the Authors Address
// Parameters: None
// Returns: Authors address.
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
string Book::getAddress() const { return _author.getAddress(); }


// Purpose: Read in data from a txt file.
// Parameters: ifstream object
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
void Book::readData(ifstream& in)
{
	string conversion;
	string doubleconversion;
	string authorName;
	string authorAddress;
	try {
		getline(in, authorName);
		getline(in, authorAddress);
		getline(in, _title);
		getline(in, conversion);
		getline(in, doubleconversion);

		_numPages = stoi(conversion);
		_price = stod(doubleconversion);
		_author.setName(authorName);
		_author.setAddress(authorAddress);
	}
	catch (invalid_argument e) {

		throw IOException("There was an error converting the data.", READ_ERROR);
	}

}

// Purpose: Writes out book data to file.
// Parameters: ofstream object
// Returns: None
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
void Book::writeData(ofstream& out)
{
	out << _author.getName() << '\n' << _author.getAddress() << '\n' <<  _title << '\n' << _numPages << '\n' << _price  << endl;
	

}