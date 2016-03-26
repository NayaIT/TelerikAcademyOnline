/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

using System;

class RandomNumGivenRange
{
    static void Main()
    {
        Console.Write("Please enter the number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter the number m: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Please enter the number p: ");
        int max = int.Parse(Console.ReadLine());

        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", r.Next(min, max + 1));
        }
    }
}

