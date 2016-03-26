
//Problem 15. Hexadecimal to Decimal Number
//
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Text;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        string n = Console.ReadLine();

        Console.WriteLine(Convert.ToInt32(n, 16));
    }
}

