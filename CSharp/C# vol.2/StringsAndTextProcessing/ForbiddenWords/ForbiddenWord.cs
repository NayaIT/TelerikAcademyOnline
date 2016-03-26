/* Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.*/

namespace ForbiddenWords
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;


    class ForbiddenWord
    {
        static void Main()
        {
            Console.Write("Please enter a text: ");
            string text = Console.ReadLine();
            Console.Write("Enter forbidden words separated by a space or comma: ");
            string[] forbiddenWords = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            Console.WriteLine(Environment.NewLine + Censore(text, forbiddenWords));
        }

        private static string Censore(string text, string[] forbiddenWords)
        {
            return Regex.Replace(text, String.Join("|", forbiddenWords), delegate(Match match)
            {
                string current = match.ToString();
                return Regex.Replace(current, current, new String('*', current.Length));
            },  RegexOptions.IgnoreCase);
        }
    }
}
