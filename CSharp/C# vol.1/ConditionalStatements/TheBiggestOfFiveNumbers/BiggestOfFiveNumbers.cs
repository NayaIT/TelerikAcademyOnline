//Problem 6. The Biggest of Five Numbers
//
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the forth number: ");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());


        double greaterAB = Math.Max(a, b);
        double greaterABC = Math.Max(greaterAB, c);
        double greaterDE = Math.Max(d, e);
        double greaterABCDE = Math.Max(greaterABC, greaterDE);

        Console.WriteLine("\nThe bigest number is: " + greaterABCDE);
    }
}
