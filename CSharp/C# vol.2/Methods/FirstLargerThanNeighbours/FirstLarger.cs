/* Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise. */

using System;
using System.Linq;
class FirstLarger
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

        Console.WriteLine("The first element, larger than it's neighbours in [{0}]\nis at index: {1}",
           string.Join(", ", array), FirstLargerThanNeighbours(array));
       
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

    static int FirstLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (CheckNeighbours(array, i)) 
            {                                                   
                return i;                                       
            }                                                   
        }                                                      
        return -1;                                              
    }  
}
