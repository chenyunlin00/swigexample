// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;

var person = new Person("Bright");
var test = new Test();
Console.WriteLine("1+2=" + test.Add(1, 2).ToString());
Console.Write(test.Greet(person, 3, 4));
