/* Problem 1. Say Hello
Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.*/

using System;

class Hello
{
    
    static void Main()
    {
        PrintName();
    }

    static void PrintName()
    {
        Console.Write("Please enter your first name here: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", name);

    }
}

