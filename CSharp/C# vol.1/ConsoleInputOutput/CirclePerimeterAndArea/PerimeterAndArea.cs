/* Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. */


using System;

class PerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = (2 * radius) * Math.PI;
        Console.Write("\nThe perimeter of circle with radius {0} is: {1:0.00}", radius, perimeter);

        double area = Math.PI * Math.Sqrt(radius);
        Console.Write("\nThe area of the circle is: {0:F2}\n", area);
    }
}

