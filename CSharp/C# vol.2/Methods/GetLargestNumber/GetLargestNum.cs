/* Problem 2. Get largest number
Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax(). */

using System;

class GetLargestNum
{
    static void Main()
    {
        PrintTheLargestNumber();

    }
    static void PrintTheLargestNumber()
    {

        Console.Write("Please enter three integers. \nA = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("From the given integers tha largest is: ");
        Console.WriteLine(GetMax(GetMax(a, b), c));

    }

    static int GetMax(int numberOne, int numberTwo)
    {


        if (numberOne > numberTwo)
        {
            return numberOne;
        }
        else
        {
            return numberTwo;
        }

    }
}
