#include "a.h"

#include <iostream>
#include <sstream>

using namespace std;

int Test::Add(int a, int b)
{
	return a+b;
}

Person::Person(string name):_name(name) {}

string Test::Greet(Person *ptr, int a, int b)
{
	ostringstream buffer;
	buffer << "Hello " << ptr->_name.c_str() << "! " << "You inputed " << a << " " << b << endl;
	return buffer.str();
}
