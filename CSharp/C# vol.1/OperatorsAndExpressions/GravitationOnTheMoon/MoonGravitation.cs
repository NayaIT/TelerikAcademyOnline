//Problem 2. Gravitation on the Moon
//
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class MoonGravitation
{
    static void Main()
    {
        Console.Write("Please enter your weight: ");
        double weightOnTheEarth = double.Parse(Console.ReadLine());

        double weightOnTheMoon = weightOnTheEarth * 0.17;
        Console.WriteLine("\nYour weight on Earth is {0} on the moon will be {1}. ", weightOnTheEarth, weightOnTheMoon);
    }
}

