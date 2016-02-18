// Author: Matthew Cranford
// Assignment: Lab 07
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: Feb 17th 2016
// Description: myVector Class Definition

// I declare that the following source code was written solely by me.
// I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.


/*
Pseudo-Code:
    #1. A default constructor that creates an vector with a default capacity of 2
    #2. A parameterized constructor that creates a vector of capacity n
    #3. A destructor that deletes any dynamically allocated storage. 
			-The destructor has the same name as the class, but begins with a ~. 
			-The destructor has no return type and takes no parameters, for example ~MyVector()
			-Note that you program should not have any memory leaks.

    #4. A function, size( ), that returns the size of your vector.
    #5. A function, capacity( ), that returns the capacity of the vector.
    #6. A function, clear( ), that deletes all of the elements from the vector and resets its size to zero and its capacity to two.
    #7. A function push_back(int n) that adds the integer value n to the end of the vector. 
			-If the vector is not large enough to hold this additional value, you must make the vector grow. 
			-Your grow algorithm should double the current capacity of the vector. 
			-Don't forget to consider the case where the initial capacity of the vector is zero.

    #8. A function at(int n) that returns the value of the element at position n in the vector. 
			-If the index n is greater than the size( ) of the vector, this function should throw an exception. 
*/



#pragma once
class myVector
{
public:

	// Purpose: Default Constructor
	// Parameters: None
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	myVector();

	// Purpose: Paramtertized constructor
	// Parameters: int 
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	myVector(int);

	// Purpose: Default Deconstructor
	// Parameters: None
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: deletes array pointer
	// -----------------------------------------------------------------
	~myVector();

	
	// Purpose: Returns size of the array (How many spaces are being used).
	// Parameters: None
	// Returns: int size
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int size() const;

	// Purpose: Returns the capacity of the array (how much it can hold)
	// Parameters: None
	// Returns: int capacity
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int capacity() const;

	// Purpose: Resets the array.
	// Parameters: None
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: Resets the array to default constructor status.
	// -----------------------------------------------------------------
	void clear();

	// Purpose: Adds an int value into the end of the array.
	// Parameters: int 
	// Returns: None
	// Pre-conditions: None
	// Post-conditions: The array's capacity may double, and or the size of the array will increase.
	// -----------------------------------------------------------------
	void push_back(int);


	// Purpose: Returns the value at the given index.
	// Parameters: int n (index)
	// Returns: int Value at given index
	// Pre-conditions: None
	// Post-conditions: None
	// -----------------------------------------------------------------
	int at(int);

private:

	
	int _size;
	int _capacity;
	int* _data;

};

