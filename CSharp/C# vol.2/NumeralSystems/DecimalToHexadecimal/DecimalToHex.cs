/* Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("\nThe representation of decimal number {0} to hexadecimal is {1}.", decimalNumber, ConvertDecimalToHexadecimal(decimalNumber));
    }

    static string ConvertDecimalToHexadecimal(int input)
    {
        string hex = "";
        if (input == 0)
        {
            hex = "0";
        }
        else
        {
            while (input > 0)
            {
                switch (input % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        hex = input % 16 + hex;
                        break;
                    case 10:
                        hex = "A" + hex;
                        break;
                    case 11:
                        hex = "B" + hex;
                        break;
                    case 12:
                        hex = "C" + hex;
                        break;
                    case 13:
                        hex = "D" + hex;
                        break;
                    case 14:
                        hex = "E" + hex;
                        break;
                    case 15:
                        hex = "F" + hex;
                        break;
                }
                input /= 16;
            }
        }
        return hex;
    }
}
