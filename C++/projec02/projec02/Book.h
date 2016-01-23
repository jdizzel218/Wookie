#pragma once
#ifndef Book_H
#define Book_H

using namespace std;

class Book
{
public:
	Book();
	

	Book(const Author&, const string&, int, double);
	
	Author GetAuthor() const;
	string GetBookTitle()const;
	int GetNumberOfPages()const;
	double GetBookPrice() const;


private:
	Author theAuthor;
	string _title;
	int _numPages;
	double _price;


};

#endif // !Book_H