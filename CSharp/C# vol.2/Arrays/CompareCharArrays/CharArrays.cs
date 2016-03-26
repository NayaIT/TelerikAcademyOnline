/* Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

class CharArrays
{
    static void Main()
    {
        //read first arra
        Console.WriteLine("Enter first word: ");
        char[] firstWord = Console.ReadLine().ToCharArray();
        
        //read second array
        Console.WriteLine("Enter second word: ");
        char[] secondtWord = Console.ReadLine().ToCharArray();

        string lexicographicallyFirst = string.Join("", firstWord);
        int length = Math.Min(firstWord.Length, secondtWord.Length);

 
            for (int i = 0; i < length; i++)
            {
                if (firstWord[i] != secondtWord[i])
                {
                    lexicographicallyFirst = string.Join("", secondtWord);
                    break;
                }
            }

            Console.WriteLine("The first lexicographically of the both cgar arrays is: " + lexicographicallyFirst);
    }
}

