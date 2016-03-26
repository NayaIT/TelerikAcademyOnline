/* Problem 9. Frequent number

Write a program that finds the most frequent number in an array.*/

using System;
using System.Linq;
class FrequentNum
{
    static void Main()
    {
        Console.WriteLine("Enter integers separated by a comma: ");
        int[] inputNumbers = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        var number = (from numbers in inputNumbers
                      group numbers by numbers into gr
                      orderby gr.Count() descending
                      select new { Number = gr.Key, Frequency = gr.Count() }).First();

        Console.WriteLine("The most frequent number is {0} ({1} times)",
            number.Number, number.Frequency);
    }
}

