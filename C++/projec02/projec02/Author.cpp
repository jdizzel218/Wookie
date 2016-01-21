
#pragma once
#include <string>

using namespace std;


class Author
{
private:
	string _name = "";
	string _address = "";


public:

	Author::Author()
	{
		_name = "";
		_address = "";
	
	}

	Author::Author(string name, string address) 
	{

		_name = name;
		_address = address;
	}

	string Author::GetAuthorName()
	{
		return _name;
	}

	string Author::GetAuthorAddress() 
	{
		return _address;
	}
};