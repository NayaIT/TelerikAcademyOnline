//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
//R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleAndOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter a number for coordinate X: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number for coordinate Y: ");
        double y = double.Parse(Console.ReadLine());

        double r = 1.5;

        bool inTheCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
        bool isOutRectangle = !((x > -1 && x < 5) && (y > -1 && y < 1));

        Console.WriteLine("Is the number is inside K & outside of Rectangular?");


        if (inTheCircle && isOutRectangle)
        {
            Console.WriteLine("-Yes");
        }
        else
        {
            Console.WriteLine("-No");
        }
    }
}

