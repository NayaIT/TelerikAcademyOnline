/* Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.*/

namespace DateDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class DateDiff
    {
        static void Main()
        {
            Console.Write("Please enter first date in the format day.month.year: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter second date in the format day.month.year: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan daysBetween = firstDate - secondDate;

            Console.WriteLine("Days between: " + Math.Abs(daysBetween.Days));
        }
    }
}
