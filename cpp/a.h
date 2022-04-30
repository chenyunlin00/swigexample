#pragma once

#include <string>

class Person {
	public:
		Person(std::string name);
		std::string _name;
};

class Test {
	public:
		int Add(int a, int b);
		std::string Greet(Person *p, int a, int b);
};
