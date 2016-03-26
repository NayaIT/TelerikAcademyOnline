/* Problem 8. Extract sentences
Write a program that extracts from a given text all sentences containing given word.*/

namespace ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;


    class ExtractSentence
    {
        static void Main()
        {
            Console.WriteLine("Please enter a text:");
            string text = Console.ReadLine();

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nSentences containing word [{0}]:\n", word);

            for (int i = 0; i < sentences.Length; i++)
            {
                if (IsContainTheWord(sentences, i, word))
                {
                    Console.WriteLine(sentences[i].Trim() + ".");
                }
            }

            Console.WriteLine();
        }

        static bool IsContainTheWord(string[] sentences, int index, string word)
        {
            return Regex.Matches(sentences[index], string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count != 0;
        }
    }
}