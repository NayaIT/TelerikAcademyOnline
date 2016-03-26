/* Task 1. Quality Methods
Take the VS solution Methods and refactor its code to follow the guidelines of high-quality methods.
Ensure:
you handle errors correctly
when the methods cannot do what their name says, throw an exception (do not return wrong result).
good cohesion and coupling
good naming
no side effects, etc.*/

namespace Methods
{
    using System;

    class Methods
    {
        /// <summary>
        /// The Main method who tests all others methods
        /// </summary>
        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal = IsHorizontal(-1, 2.5);
            bool vertical = IsVertical(3, 3);

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 3, 11), "Vidin", "gamer, high results");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }

        /// <summary>
        /// This method calculates the area of a triangle by all given sides
        /// </summary>
        /// <returns>Double - the area of the triangle</returns>
        internal static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            bool positiveSides = sideA > 0 || sideB > 0 || sideC > 0;

            if (!positiveSides)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double perimeterDividedByTwo = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(perimeterDividedByTwo * (perimeterDividedByTwo - sideA) * (perimeterDividedByTwo - sideB) * (perimeterDividedByTwo - sideC));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: 
                    return "zero";
                case 1: 
                    return "one";
                case 2: 
                    return "two";
                case 3: 
                    return "three";
                case 4: 
                    return "four";
                case 5: 
                    return "five";
                case 6: 
                    return "six";
                case 7: 
                    return "seven";
                case 8: 
                    return "eight";
                case 9: 
                    return "nine";
                default: 
                    throw new ArgumentException("Invalid digit!");
            }
        }

        static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("The input array cannot be null or empty");
            }

            int maxNumber = elements[0]; 

            for (int i = 1, len = elements.Length; i < len; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
            }
        }


        internal static double CalculateDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) + (secondPointY - firstPointY) * (secondPointY - firstPointY));
            return distance;
        }

        internal static bool IsHorizontal(double firstPointY, double secondPointY)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointY - secondPointY) < AcceptableDifference;
        }

        internal static bool IsVertical(double firstPointX, double secondPointX)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointX - secondPointX) < AcceptableDifference;
        }
    }
}