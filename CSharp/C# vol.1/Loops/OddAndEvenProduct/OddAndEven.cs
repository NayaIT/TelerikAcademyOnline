/* Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;
using System.Linq;
class OddAndEven
{
    static void Main()
    {
        Console.WriteLine("Please enter the number: ");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= numbers[i];
            }
            else
            {
                evenProduct *= numbers[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("even product = {0}", evenProduct);
            Console.WriteLine("odd product = {0}", oddProduct);
        }
    }
}
