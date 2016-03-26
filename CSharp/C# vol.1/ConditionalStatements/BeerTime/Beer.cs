//Problem 10.* Beer Time
//
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM 
//designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization; 

class Beer
{
    static void Main()
    {
        Console.WriteLine("Please enter a time: ");         // the time need to be  in the following format hh:mm tt (an hour in range [01...12], a minute in range [00…59] and AM / PM);
        string timeInput = Console.ReadLine();              //DateTime isItBeerTime = DateTime.Parse(time);
                                                            //Console.WriteLine(time);
      
        try
        {
            DateTime dateTime = DateTime.ParseExact(timeInput, "h:mm tt",
                                    CultureInfo.InvariantCulture);
            TimeSpan time = dateTime.TimeOfDay;
            TimeSpan start = new TimeSpan(13, 0, 0);
            TimeSpan end = new TimeSpan(03, 0, 0);

            if ((time >= start) || (time < end))
            {
                Console.WriteLine("beer time");
            }
            
            else
            {
                Console.WriteLine("non-beer time");
            }
            }
            
            catch (Exception)
            {
                Console.WriteLine("invalid time");
            }
    }
       
}
