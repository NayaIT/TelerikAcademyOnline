/* Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/

namespace FormatNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class FormatNum
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Number represented as decimal: {0,15}", number);
            Console.WriteLine("Number represented as hexadecimal: {0,15:X}", number);
            Console.WriteLine("Number represented as percentage {0,15:P2}", number);
            Console.WriteLine("Number represented as scientific notation {0,15:E}", number);

        }
    }
}
