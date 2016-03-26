/*Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of
type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/


using System;

class FloatDouble
{
    static void Main()
    {
        //Declare some float or double variables
        float cars = 12.345f;
        float yachts = 3456.091f;

        double rims = 34.567839023;
        double boats = 8923.1234857;

        //Print the results on the console
        Console.WriteLine("Statistic's results:");
        Console.WriteLine(cars);
        Console.WriteLine(yachts);
        Console.WriteLine(rims);
        Console.WriteLine(boats);

        //Print one sentence with the results on the console
        Console.WriteLine("In the statistic of 2014 year " + cars + " people prefere to buy cars and " + yachts + " percent - yachts");                       
        Console.WriteLine( rims + " percent of people likes tuning rims for their cars, but people who buy boats for their yachts are more than " + boats);

        //Or second way to write it
        //Console.WriteLine("In the statistic of 2014 year {0} people prefere to buy cars and {1} percent - yachts", cars, yachts);
        //Console.WriteLine(" {2} percent of people likes tuning rims for their cars, but people who buy boats for their yachts are more than {3} ", rims, boats);
        
        
        //Console output:
        //In the statistic of 2014 year 12.345 people prefere to buy cars and 3456.091 percent - yachts.
        //34.567839023  percent of people likes tuning rims for their cars, but people who buy boats for 
        //their yachts are more than 8923.1234857.
    }   
}
