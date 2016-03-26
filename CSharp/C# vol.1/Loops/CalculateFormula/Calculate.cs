/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number 
of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard 
deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/

using System;
using System.Numerics;
class Calculate
{
    static void Main()
    {

        Console.Write("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number k: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factN = 1;
        BigInteger factK = 1;

        if (1 < k && n > k && n < 100)  //numbers N and K need to be in the interval of (1 < k < n < 100) 
        {
            for (int i = k + 1; i <= n; i++)
            {
                factN *= i;
            }

            for (int m = 1; m <= (n - k); m++)
            {
                factK *= m;
            }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
                BigInteger result = factN / factK;
                Console.WriteLine("N! / K!(N-K)! = {0}", result);
     
        //or we can calculate the both facturials one by one

        //BigInteger result = 1;
        //BigInteger facturialN = 1;
        //BigInteger facturialK = 1;
        //
        //while (true)
        //{
        //    if (1 < n && n < 100)
        //    {
        //        break;
        //    }
        //    facturialN *= n;
        //    n--;
        //}
        //Console.WriteLine("N! = " + facturialN);
        //
        //while (true)
        //{
        //    if (k > 1 && k < n)
        //    {
        //        break;
        //    }
        //    facturialK *= k;
        //    k--;
        //}
        //Console.WriteLine("K! = " + facturialK);
    }
}
