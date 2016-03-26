/* Task 2. Good Encapsulation
Establish good encapsulation in the classes from the VS solution Abstraction.
Ensure that incorrect values cannot be assigned in the internal state of the classes.*/

namespace Abstraction
{
    using System;

    internal class FiguresExample
    {
        private static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle. " +
                              "My perimeter is {0:f2}. My surface is {1:f2}.",
                              circle.CalculatePerimeter(), 
                              circle.CalculateSurface());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. " +
                              "My perimeter is {0:f2}. My surface is {1:f2}.",
                              rect.CalculatePerimeter(), 
                              rect.CalculateSurface());
        }
    }
}