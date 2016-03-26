/* Problem 8. Binary short
Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

using System;

class BinShort
{
    static void Main()
    {
        Console.Write("Please enter a 16-bit signed integer number: ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("\nThe representation of number {0} to binary is {1}.", number, ConvertToBinary(number));
    }

    static string ConvertToBinary(int number)
    {
        string binary = string.Empty;
        for (int i = 15; i >= 0; i--)
        {
            binary = ((number % 2) & 1) + binary;
            number >>= 1;

            if (i % 4 == 0) binary = " " + binary;
        }
        return binary;
    }
}
