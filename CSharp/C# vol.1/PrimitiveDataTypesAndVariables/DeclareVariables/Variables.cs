//Problem 1. Declare Variables
//
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
//int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.


using System;

class Variables
{
    static void Main()
    {
        byte months = 97;
        sbyte dayOff = -115;
        short unpaidHours = -10000;
        ushort paidHolidayHours = 52130;
        int allPaidHoursForTheWorkPeriod = 4825932;
        
        Console.WriteLine(months);
        Console.WriteLine(dayOff);
        Console.WriteLine(unpaidHours);
        Console.WriteLine(paidHolidayHours);
        Console.WriteLine(allPaidHoursForTheWorkPeriod);
    }
}

