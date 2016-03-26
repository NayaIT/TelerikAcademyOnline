/* Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).*/

using System;

class DigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter four-digit Integer number:" ); //The number has always exactly 4 digits and cannot start with 0.
        int number = int.Parse(Console.ReadLine());

        int d = number % 10;
            number /= 10;
        int c = number % 10;
            number /= 10;
        int b = number % 10;
            number /= 10;
        int a = number % 10;
            number /= 10;

        int sum = a + b + c + d;
        Console.WriteLine("\nThe sum of the number digits is: {0}.", sum);
        Console.WriteLine("\nThe number in reversed order is: {0}{1}{2}{3}.", d,c,b,a);
        Console.WriteLine("\nThe number when last digit go in the first position is:{0}{1}{2}{3}.", d,b,c,a);
        Console.WriteLine("\nThe number after exchanges the second and the third digits is: {0}{1}{2}{3}.", a,c,b,d);
   
    }
}

