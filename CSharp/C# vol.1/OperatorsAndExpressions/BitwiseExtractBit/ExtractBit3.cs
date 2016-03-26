/* Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0. */

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Please enter an Uinteger number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("\nThe binary representation of the number {0} is:\n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        byte bitAtPositionThree = (byte)((n >> 3) & 1);
        Console.WriteLine("\nThe bit at #3 is " + bitAtPositionThree);

    }
}

