/* Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).*/

using System;
using System.Numerics; 

class CatalanNum
{
    static void Main()
    {
        Console.Write("Please enter the number n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger divider = 1;

        if (n >= 0 && n <= 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                numerator *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }
            BigInteger result = numerator / divider;
            Console.WriteLine("\nThe Catalan number is: {1}" + result);
        }

            else
            {
                Console.WriteLine("The number is invalid");
            }
    }
}

