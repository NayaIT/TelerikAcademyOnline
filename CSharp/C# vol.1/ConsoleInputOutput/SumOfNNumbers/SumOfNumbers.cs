//Problem 9. Sum of n Numbers
//
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter count: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;

        for (double i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the {0} number", i + 1);
            double value = double.Parse(Console.ReadLine());
            sum += value;
        }
        Console.WriteLine(" The sum is: {0}", sum);
    }
}

