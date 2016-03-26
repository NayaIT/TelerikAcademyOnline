/// <summary>
/// Problem 6. Divisible by 7 and 3
/// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
/// Rewrite the same with LINQ.
/// </summary>
/// 

namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Divisible
    {

        public static void Main()
        {
            int[] arr = Enumerable.Range(1, 900).ToArray();

            Console.WriteLine("All numbers divisible by 3 and 7 at the same time: \n\nLambda expression results: ");

            Print(LambdaExpressionResult(arr));

            Console.WriteLine("\nLinq query results: ");

            Print(LinqQueryResult(arr));
        }

        public static IEnumerable<int> LambdaExpressionResult(IList<int> arr)
        {
            var lambdaResult = arr.Where(n => n % 3 == 0 && n % 7 == 0);
            return lambdaResult;
        }

        public static IEnumerable<int> LinqQueryResult(IList<int> arr)
        {
            var linqQueryResult =
                    from n in arr
                    where n % 3 == 0 && n % 7 == 0
                    select n;

            return linqQueryResult;
        }

        public static void Print(IEnumerable<int> arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}