/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

using System;

class PerimeterOfRectangles
{
    static void Main()
    {
        Console.WriteLine("Enter the width of rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of rectangle: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("We have an rectangle with width {0} and height {1}. The perimeter is {2} and the area is {3}.", width, height, perimeter, area);
    }
}

