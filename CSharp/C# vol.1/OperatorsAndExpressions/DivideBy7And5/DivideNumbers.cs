/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder)
by 7 and 5 at the same time.*/


using System;

class DivideNumbers
{
    static void Main()
    {
      
        Console.Write("Please enter an Integer number: ");
        int number = int.Parse(Console.ReadLine());

        bool divide = ((number % 7)) == 0 && ((number % 5) == 0);
        Console.WriteLine("\nIs {0} divisible by 5 and 7 at the same time? \n- {1}", number, divide);
   
    }
}

