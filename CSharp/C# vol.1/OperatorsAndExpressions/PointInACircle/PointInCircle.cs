//Problem 7. Point in a Circle
//
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).


using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter a number for coordinate X: ");
        double x = double.Parse(Console.ReadLine());
      
        Console.WriteLine("Enter a number for coordinate Y: ");
        double y = double.Parse(Console.ReadLine());

        int radius = 2;
        
        bool isItInTheCircle = (x * x + y * y) <= radius * radius;
        
        Console.WriteLine("Is the point with the coordinates ({0},{1}) in the circle? \n- {2}", x, y, isItInTheCircle);

    }
}
