﻿/* Problem 5. Sort by string length
You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/


using System;
using System.Linq;
using System.Collections.Generic;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter words, separated by a comma: ");
        var words = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
            .OrderByDescending(x => x.Length)
            .ToList();

        words = words.Distinct().ToList();
            
        foreach (var word in words)
        {
            Console.WriteLine("{0,-6}{1}", word.Length, word);
        }
    }
}
            //Console.Write("Enter a number N (size of array): ");
            //int N = int.Parse(Console.ReadLine());
            //
            //string[] elements = new string[N];
            //Console.WriteLine("\nEnter {0} string(s) to array: ", N);
            //
            //for (int i = 0; i < elements.Length; i++)
            //{
            //    Console.Write("   {0}: ", i + 1);
            //    elements[i] = Console.ReadLine();
            //}
            //
            //Console.WriteLine("\nBefore sorting: {0}\n", string.Join(" ", elements));
            //
            //SelectionSortByLength(ref elements);
            //
            //Console.WriteLine("After sorting: {0}\n", string.Join(" ", elements));
            //  }
            //
            //static void SelectionSortByLength(ref string[] elements)
            //{
            //for (int i = 0; i < elements.Length - 1; i++)
            //{
            //    int index = i;
            //
            //    for (int j = i + 1; j < elements.Length; j++)
            //    {
            //        if (elements[j].Length < elements[index].Length) index = j;
            //    }
            //
            //    string swap = elements[i];
            //    elements[i] = elements[index];
            //    elements[index] = swap;
            //}
 