﻿/*Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after
6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

namespace DateInBulgarian
{
    using System;
    using System.Globalization;


    class DateBG
    {
        static void Main()
        {
            Console.WriteLine("Please enter a date i the following format day.month.year hour:minute:second: ");
            string time = Console.ReadLine(); //test with "18.05.2015 07:22:09"
            DateTime date = DateTime.ParseExact(time, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);
            Console.WriteLine("{0} {1}", date.ToString("dddd"), date);
        }
    }
}
