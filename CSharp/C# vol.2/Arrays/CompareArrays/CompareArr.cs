/* Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element. */

using System;

class CompareArr
{
    static void Main()
    {
        //read the first array from the console
        Console.Write("Please enter length of first array: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter first array: ");
        int[] firstArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        //read the second array from the console
        Console.Write("Please enter the length of second array: ");
        n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter second array: ");
        int[] secondArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        if (firstArr.Length != secondArr.Length)
        {
            areEqual = false;
        }
        else
        {
            for (int i = 0; i < firstArr.Length && areEqual; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                }
                
            }
        }

        Console.WriteLine("Are the both arrays equal: " + areEqual);

    }
}

