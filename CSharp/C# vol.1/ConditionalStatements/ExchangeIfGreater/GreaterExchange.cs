/* Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
As a result print the values a and b, separated by a space.*/

using System;

class GreaterExchange
{
    static void Main()
    {
        Console.WriteLine("Enter first double variable A: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second double variable B: ");
        double b = double.Parse(Console.ReadLine());

        double greaterAB = Math.Max (a, b);
        Console.WriteLine("\nThe greater number is: " + greaterAB);
        double c = 0;

        if (a > b)
        {
            c = a;
            a = b;
            b = c;

        }

        Console.WriteLine("\n{0} {1}", a, b);

    }

        
}
