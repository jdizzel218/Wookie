#pragma once
#ifndef Author_H
#define Author_H
class Author
{
private:
	string _name;
	string _address;

public:
	Author()
	{
	
	}

	Author(string name, string address)
	{
	
	}

	string GetAuthorName() { return _name; }
	string GetAuthorAddress() { return _address; }

};

#endif