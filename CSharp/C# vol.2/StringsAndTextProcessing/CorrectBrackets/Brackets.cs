/* Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.*/

namespace CorrectBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Brackets
    {
        static void Main()
        {
            Console.Write("Enter an expression: ");
            string inputStr = Console.ReadLine();
            Console.WriteLine("In this expression the brackets are correct ? - {0}", CheckForCorrectBrackets(inputStr));

        }

        public static bool CheckForCorrectBrackets(string str)
        {
            if (str.IndexOf('(') > str.IndexOf(')'))
            {
                return false;
            }
            return true;
        }
    }
}
