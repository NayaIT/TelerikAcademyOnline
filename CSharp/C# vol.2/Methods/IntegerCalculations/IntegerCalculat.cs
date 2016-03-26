/* Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.*/﻿

using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculat
{
    static void Main()
    {
        Console.WriteLine("Please enter integers: "); //the integers need to be separated by a comma or space
        int[] array = Console.ReadLine()
                          .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();

        Console.WriteLine("\nMin: {0}\nMax: {1}\nAverage: {2}\nSum: {3}\nProduct: {4}",
            Minimum(array), Maximum(array), Average(array), Sum(array), Product(array));
    }

    static int Minimum (params int[] array)
    {
        return array.Min();
    }
    static int Maximum (params int[] array)
    {
        return array.Max();
    }
    static double Average(params int[] array)
    {
        List<int> list = array.ToList();
        return list.Average();
    }
    static long Sum (params int[] array)
    {
        return array.Sum();
    }
    static long Product (params int[] array)
    {
        long product = 1;
        foreach (var item in array)
        {
            product *= item;
        }
        return product;
    }
}
