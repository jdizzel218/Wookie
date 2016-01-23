
#pragma once

#include <string>
#include "Author.h"
using namespace std;

class Book
{
private:
	string _title = "None";
	int _numPages = 0;
	double _price = 0.0;

	Author author;


public:
	Book::Book()
	{
		_title = "";
		_numPages = 0;
		_price = 0.0;
	}

	Book::Book(const Author& author, string title, int numberOfPages, double price)
	{
		_title = title;
		_numPages = numberOfPages;
		_price = price;
	
	}

	string Book::GetBookTitle()
	{
		return _title;
	
	}

	int Book::GetNumberOfPages()
	{
		return _numPages;
	}

	double Book::GetBookPrice()
	{
		return _price;
	
	}

};