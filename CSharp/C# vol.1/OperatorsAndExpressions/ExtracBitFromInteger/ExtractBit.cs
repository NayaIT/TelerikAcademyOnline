//Problem 12. Extract Bit from Integer
//
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.WriteLine("Please enter an Integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe binary representation of the number {0} is:\n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        byte bitAtPosition = (byte)((n >> p) & 1);
        Console.WriteLine("\nThe bit at #{0} is {1}", p, bitAtPosition);

    }
}

