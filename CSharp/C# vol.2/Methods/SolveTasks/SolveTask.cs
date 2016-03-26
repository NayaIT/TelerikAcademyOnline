/* Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0 */

using System;
using System.Collections.Generic;
using System.Linq;
class SolveTask
{
    static void Main()
    {
        Console.WriteLine("Please choose an option from the menu:\n1. Reverse digits of a number\n2. Calculate average\n3. Solve linear equation");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                Console.WriteLine("Enter positive integer: ");
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("The reversed number: {0}", ReverseDigits(number));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                break;
            case 2:
                Console.WriteLine("Enter a sequence of positive integers, separated by space (must not be empty): ");
                string sequence = Console.ReadLine();
                List<int> list = sequence.Split(' ').Select(x => int.Parse(x)).ToList();
                if (list.Count > 0)
                {
                    Console.WriteLine("The average of these numbers: {0}", CalculateAverage(list));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                break;
            case 3:
                Console.Write("Enter a and b for the equation a*x + b = 0:\na (must be != 0): ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                if (a != 0)
                {
                    Console.WriteLine("x = {0}", SolveEquation(a, b));
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
        Main();
    }

    static int ReverseDigits(int number)
    {
        string result = "";

        for (int i = 0; i < number.ToString().Length; i++)
        {
            result = number.ToString()[i] + result;
        }

        return int.Parse(result);
    }

    static double CalculateAverage(List<int> list)
    {
        return list.Average();
    }

    private static double SolveEquation(double a, double b)
    {
        return -b/a;
    }
}
}
