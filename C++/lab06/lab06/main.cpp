// Author: Matthew Cranford
// Assignment: Lab 06
// Instructor: Lynn Thackery
// Class: CNS 1250 Section: 003
// Date Written: Feb 12 2016
// Description: Word Reverser using Pointers

//I declare that the following source code was written solely by me, or was demostrated in class by the teacher.
//I understand that copying any source code, in whole or in part,
//constitutes cheating, and that I will receive a zero on this project
//if I am found in violation of this policy.


/*
Pseudo-Code:
#1.Using a loop, determine the size of the string by counting characters until you encounter the null terminating character at the end of the string.
#2.Establish a pointer that points to the beginning character of the string.
#3.Establish a pointer that points to the last character in the string, this is the character just before the null terminating character.#4.
#4.Using the pointers, swap the first character in the string and the last character in the string.
#5.Move the pointers so that the first pointer points to the 2nd character in the string and the second pointer points to the next to last character in the string. Swap these two characters.
#6.Repeat this process until all of the characters have been swapped. The string should now be reversed.

*/
#include <iostream>

using namespace std;


// Purpose: Reverses a word
// Parameters: char* word
// Returns: none
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
void reverseWord(char* word) {

	char* endOfWord = word;

	do {

		endOfWord++;
	} while (*endOfWord != '\0');


	endOfWord--;

	do {
		char tmp = *word;
		*word = *endOfWord;
		*endOfWord = tmp;

		word++;
		endOfWord--;
	} while (word <= endOfWord);
}


// Purpose: Main entry point into program
// Parameters: None
// Returns: 0 if program exits correctly.
// Pre-conditions: None
// Post-conditions: None
// -----------------------------------------------------------------
int main()
{
	// declare a c-string to reverse
	char myString[] = "Hello world!";

	// call the reverser function
	reverseWord(myString);

	// output the result
	cout << myString << endl;

	system("PAUSE");
	return 0;
}



