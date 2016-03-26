/* Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/

using System;
using System.Linq;
class AppCount
{
    static void Main()
    {

        GivenNumberAppearsInArray();
    }

    static void GivenNumberAppearsInArray ()
    {
        Console.WriteLine("Please enter integers: "); //the integers need to be separated by a comma or space
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

