/* Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement. */

using System;

class PlayWith
{
    static void Main()
    {
        Console.Write(@"Please choice the type (1 - int, 2 - double, 3 - string): ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.WriteLine("Enter a int: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(++n);
                break;

            case 2:
                Console.WriteLine("Enter a double: ");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(++num);
                break;
            case 3:
                Console.WriteLine("Enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + '*');
                break;
            default:
                Console.WriteLine("Invalid type");
                break;
        }
    }
}

