/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:*/


using System;

class Triangle
{
    static void Main()
    {

        int uniCode = 169;
        char symbol = '\u00A9';

        Console.WriteLine("The Unicode code {0} (decimal) is with the character symbol {1}.", uniCode, symbol);
        Console.WriteLine("We use nine symbols to make a triangle.\n" );

        Console.WriteLine("    {0} \n", symbol);
        Console.WriteLine("   {0} {0} \n", symbol);
        Console.WriteLine("  {0}   {0} \n", symbol);
        Console.WriteLine(" {0} {0} {0} {0}\n", symbol);

    }
}
