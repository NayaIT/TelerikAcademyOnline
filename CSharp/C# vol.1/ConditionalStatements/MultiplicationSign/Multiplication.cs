/* Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators. */

using System;

class Multiplication
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("\nThe sign is : ");

        if (a == 0 || b == 0 || c == 0)
        {
            Console.Write("0\n");
        }

        else if (a < 0 && b < 0 && c <0)
        {
            Console.Write("-\n");
        }

        else if (a > 0 && b > 0 && c > 0)
        {
            Console.Write("+\n");
        }

        else if ((a > 0 && b < 0 && c > 0)|(a < 0 && b > 0 && c > 0)|(a > 0 && b > 0 && c < 0))
        {
            Console.Write("-\n");
        }

        else if ((a < 0 && b < 0 && c > 0)|(a < 0 && b > 0 && c < 0)|(a > 0 && b < 0 && c < 0))
        {
            Console.Write("+\n");
        }

    }
}

