/* Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
in given integer number n, has value of 1. */

using System;

class BitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter an Integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe binary representation of the number {0} is:\n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        bool bitAtPosition = ((n >> p) & 1) == 1;
        Console.WriteLine("\nIs bit at  position {0} == 1?  \n-{1}", p, bitAtPosition);
    }
}

