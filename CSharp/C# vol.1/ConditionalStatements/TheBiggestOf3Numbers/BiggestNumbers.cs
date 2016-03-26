using System;

class BiggestNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());


        double greaterAB = Math.Max(a, b);
        double greaterABC = Math.Max(greaterAB, c);
        Console.WriteLine("\nThe bigest number is: " + greaterABC);
    }
}

