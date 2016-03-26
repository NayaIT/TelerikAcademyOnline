/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number A : ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number B : ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number C : ");
        double c = double.Parse(Console.ReadLine());

        double sum = (a + b) + c;

        Console.WriteLine("\nThe sum of the numbers A, B and C is: " + sum);




    }
}

