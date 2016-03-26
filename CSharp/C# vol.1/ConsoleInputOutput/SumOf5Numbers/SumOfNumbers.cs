/* Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter five numbers: ");  //enter the numbers each one given in a single line, separated by a space 
        string[] fiveNum = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < fiveNum.Length; i++)
        {
            sum += Convert.ToDouble(fiveNum[i]);
        }
        Console.WriteLine("Sum is = {0}", sum);
  
    }
}

