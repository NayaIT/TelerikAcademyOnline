/* Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Linq;
class SortingArr
{
    static void Main()
    {
        Console.WriteLine("Please enter integers: "); //the integers need to be separated by a comma or space
        int[] array = Console.ReadLine()
                          .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();

        Console.WriteLine("Initial array: {0}", string.Join(", ", array));
        Console.WriteLine("Sorted ascending: {0}", string.Join(", ", SortAscending(array)));
        Console.WriteLine("Sorted descending: {0}", string.Join(", ", Sort(array)));
    }

    static int LargestValue(int[] array, int start, int end) 
    {                                                              
        return array.Skip(start).Take(end - start).Max();
    }

    static int[] SortAscending(int[] array)                     
    {                                                            
        for (int i = 0; i < array.Length; i++)                  
        {                                                       
            int max = LargestValue(array, 0, array.Length - i); 

            array[Array.IndexOf(array, max)] = array[array.Length - i - 1];
            array[array.Length - i - 1] = max;
        }
        return array;
    }

    static int[] Sort(int[] array)                    
    {                                                           
        for (int i = 0; i < array.Length; i++)                  
        {
            int max = LargestValue(array, i, array.Length);

            array[Array.IndexOf(array, max)] = array[i];
            array[i] = max;
        }
        return array;
    }
}
