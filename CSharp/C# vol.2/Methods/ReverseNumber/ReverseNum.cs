/* Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.*/

using System;
using System.Linq;

class ReverseNum
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.Write("Reversed: ");
        decimal reversed = ReverseNumber(number);
        Console.WriteLine(reversed);

    }
    static decimal ReverseNumber(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }

}

