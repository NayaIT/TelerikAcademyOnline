/* Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements. */

using System;

class SortNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());


        if (a > b)
        {
            if (a > c)
            {
                if (c > b)
                {
                    Console.WriteLine("\nThe numbers sorted in descending order: {0} {1} {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("\nThe numbers sorted in descending order: {0} {1} {2}", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("\nThe numbers sorted in descending order: {0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("\nThe numbers sorted in descending order: {0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("\nThe numbers sorted in descending order: {0} {1} {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("\nThe numbers sorted in descending order: {0} {1} {2}", c, b, a);
            }
        }


        //double greaterAB = Math.Max(a, b);

        //if ((a > b && a > c) | (b > c))
        //{
        //    Console.WriteLine("\nThe numbers sorted in descending order: " + a + b + c);
        //}
        //
        //else if ((a > b && a > c) | (b < c))
        //{
        //    Console.WriteLine("\nThe numbers sorted in descending order: " + a + c + b);
        //}
        //
        //else if (a < b && a > c)
        //{
        //    Console.WriteLine("\nThe numbers sorted in descending order: " + b + a + c);
        //}
        //
        //else if ((a < b && a < c)|(b > c))
        //{
        //    Console.WriteLine("\nThe numbers sorted in descending order: " + b + c + a);
        //}
        //else if (a < c && a > b)
        //{
        //    Console.WriteLine("\nThe numbers sorted in descending order: " + c + a + b);
        //}
        //
        //else if (c > b && a < b)
        //{
        //    Console.WriteLine("\nThe numbers sorted in descending order: " + c + b + a);
        //
        //}
    }
}
