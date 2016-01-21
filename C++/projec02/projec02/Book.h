#pragma once
#ifndef Book_H
#define Book_H


class Book
{
private:
	string _title;
	int _numPages;
	double _price;

public:
	Book()
	{
	
	}

	Book(string title, int numberOfPages, double bookPrice)
	{
		_title = title;
		_numPages = numberOfPages;
		_price = bookPrice;
	
	}

	string GetBookTitle() { return _title; }
	int GetNumberOfPages() { return _numPages; }
	double GetBookPrice() { return _price; }

};

#endif // !Book_H