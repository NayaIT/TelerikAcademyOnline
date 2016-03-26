//Problem 5. Third Digit is 7?
//
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());

        bool isSeven = (number / 100) % 10 == 7;
        Console.WriteLine("The third digit is 7? \n- " + isSeven);
    }
}

