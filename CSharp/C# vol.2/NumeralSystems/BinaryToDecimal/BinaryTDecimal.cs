/* Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.*/

using System;

class BinaryTDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        Console.WriteLine("\nThe representation of binary number {0} to decimal is {1}.", binaryNumber, ConvertBinaryToDecimal(binaryNumber));
    }

    static long ConvertBinaryToDecimal(string binaryNumber)
    {
        long result = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            result += (long.Parse(binaryNumber[binaryNumber.Length - 1 - i].ToString())) * (long)Math.Pow(2, i);
        }
        return result;
    }
}
