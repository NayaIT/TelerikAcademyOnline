/*Problem 6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/


using System;

class StringNObjects
{
    static void Main()
    {
        //Declare some variables
        string first = "Hello";
        string second = "World";

        object firstSecond = first + " " + second;
        string third = (string)firstSecond; // or string thirdVariable = firstSecond.ToString (); 
        
        //Console output: Hello World
        Console.WriteLine(third);
    }
}

