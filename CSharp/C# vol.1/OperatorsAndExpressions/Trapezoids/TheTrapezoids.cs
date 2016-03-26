/* Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h. */

using System;

class TheTrapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter the side 'A' of the Trapezoids: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the side 'B' of the Trapezoids: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height 'H' of the Trapezoids: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.WriteLine("The trapezoid's area is: " + area );
    }
}

