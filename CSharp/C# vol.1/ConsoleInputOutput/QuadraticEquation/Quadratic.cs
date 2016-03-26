//Problem 6. Quadratic Equation
//
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class Quadratic
{
    static void Main()
    {
        Console.WriteLine("Please enter the coefficients A: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coefficients B: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coefficients C: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {

            Console.WriteLine("There are no real roots");       //There is no solution
        }
        else
        {

            double discriminantRoot = Math.Sqrt(discriminant);   //if there is only one solution, both x's will be the same
            double x1 = (-b + discriminantRoot) / (2 * a);
            double x2 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ?
                                "The Equasion got one real root {0}"
                                : "The Equasion got two real roots {0} {1}"
                                , x1, x2);


        }
    }
}
