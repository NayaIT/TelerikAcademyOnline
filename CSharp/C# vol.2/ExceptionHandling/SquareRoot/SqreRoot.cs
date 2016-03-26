/* Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.*/

namespace SquareRoot
{
    using System;
    class SqreRoot
    {
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            double number = double.Parse(Console.ReadLine());

            try
            {
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {
                if (number==0 || number < 0)
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

        //or we can use two methods
        //static double ReadNumber()
        //{
        //    Console.Write("Please enter an integer number: ");
        //    double number = double.Parse(Console.ReadLine());
        //}
    }
}
