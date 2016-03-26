/* Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100.*/

namespace EnterNumbers
{
    using System;
    class EnterNum
    {
        static void Main()
        {

            try
            {
                Console.WriteLine("Please enter start number: ");
                int startNum = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter end number: ");
                int endNum = Int32.Parse(Console.ReadLine());
                ReadNumbers(startNum, endNum);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
             

            static void ReadNumbers(int startNum, int endNum )
            {
                for (int i = 0; i < 9; i++)
                {
                    int numb = Int32.Parse(Console.ReadLine());
                    if (numb < startNum || numb > endNum)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

    }
}
