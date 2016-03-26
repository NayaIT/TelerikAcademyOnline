/*Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/

using System;

class OddOrEvenInt
{
    static void Main()
    {
        Console.WriteLine("Please enter an Integer number: ");
        int number = int.Parse(Console.ReadLine());
                                                                                    //or if we want to check just is it odd one:
        bool check = number % 2 == 0;                                               //bool odd = (number % 2) != 0;
        Console.WriteLine("The integer number is {0}", check ? "even" : "odd");     //Console.WriteLine("Is {0} odd number?  \n-{1}", number, odd);
        
    }
}

