/* Problem 1. Decimal to binary
 Write a program to convert decimal numbers to their binary representation. */

using System;

class DecimalTBinary
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("\nThe representation of decimal number {0} to binary is {1}.", decimalNumber, ConvertDecimalToBinary(decimalNumber));
    }

    static string ConvertDecimalToBinary(int input)
    {
        string result = "";
        if (input == 0)
        {
            result = "0";
        }
        else
        {
            while (input > 0)
            {
                result = input % 2 + result;
                input /= 2;
            }
        }

        return result;
    }
}


