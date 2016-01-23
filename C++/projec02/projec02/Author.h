#pragma once
#ifndef Author_H
#define Author_H

using namespace std;

class Author
{

public:
	Author()
	{

	}

	Author(const string&, const string&)
	{

	}

	string GetAuthorName() const;
	string GetAuthorAddress() const;

private:
	string _name;
	string _address;


};

#endif