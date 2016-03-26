/* Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).*/

using System;
using System.Linq;
class LargeNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please enter integers: "); //the integers need to be separated by a comma or space
        int[] array = Console.ReadLine()
                          .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
        Console.WriteLine("Enter the position of element in the array: ");
        int index = int.Parse(Console.ReadLine());


        Console.WriteLine("The element at index {0} in [{1}]\nis larger than it's neighbours --> {2}",
        index, string.Join(", ", array), CheckNeighbours(array, index));
        Console.WriteLine();

        //if we want to check all elements in the given array, we can use for loop
        //for (int i = 0; i < testArray1.Length; i++)
        //{
        //    Console.WriteLine("The element at index {0} in [{1}]\nis larger than it's neighbours --> {2}",
        //    i, string.Join(", ", testArray1), CheckNeighbours(testArray1, i));
        //    Console.WriteLine();
        //}
    }

    public static bool CheckNeighbours(int[] array, int index)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (index > 0 && index < array.Length - 1 && array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
        }
        return false;
    }
}


