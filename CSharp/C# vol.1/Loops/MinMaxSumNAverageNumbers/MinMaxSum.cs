//Problem 3. Min, Max, Sum and Average of N Numbers
//
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSum
{
    static void Main()
    {

        Console.Write("Please enter a sequence of integer numbers n: ");
        int n = int.Parse(Console.ReadLine());

        int input;
        int sum = 0;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            input = int.Parse(Console.ReadLine());

            sum += input;
            if (input > maxValue)
            {
                maxValue = input;
            }
            if (input < minValue)
            {
                minValue = input;
            }
        }
        double average = (double)sum / (double)n;
        Console.WriteLine("\nmin = {0}\nmax = {1}\nsum = {2}\navg = {3 :F2}"
                            , minValue, maxValue, sum, average);
    }
}
