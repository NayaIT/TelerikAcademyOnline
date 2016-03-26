/* Problem 7. One system to any other
Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/

using System;

class SystemToAnyOther
{
    static void Main()
    {
        Console.Write("Please enter a number: "); //in any numeral system in the range (2 ≤ s, d ≤ 16)
        string number = Console.ReadLine().ToUpper();
        Console.Write("Enter base system: ");
        int fromBase = int.Parse(Console.ReadLine());
        Console.Write("Enter target system: ");
        int target = int.Parse(Console.ReadLine());

        long decimalNumber = ConvertToDecimal(number, fromBase);
        string result = ConvertFromDecimal(decimalNumber, target);

        Console.WriteLine("\nThe starting number is: {0}\nThe number in the target system: {1}", 
            number, result);
    }

    static long ConvertToDecimal(string number, int fromBase)
    {
        long result = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(number[i]))
            {
                result += int.Parse(number[i].ToString())*(long) Math.Pow(fromBase, number.Length - i - 1);
            }
            else
            {
                result += (number[i] - 'A' + 10)*(long) Math.Pow(fromBase, number.Length - i - 1);
            }
        }
        return result;
    }

    static string ConvertFromDecimal(long number, int toBase)
    {
        string result = "";
        if (number == 0)
        {
            result = "0";
        }
        else
        {
            while (number > 0)
            {
                if (number % toBase < 10)
                {
                    result = number % toBase + result;    
                }
                else
                {
                    result = (char)(number%toBase + 'A' - 10) + result;
                }
                number /= toBase;
            }    
        }
        return result;
    }
}


