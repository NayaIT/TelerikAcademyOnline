/* Problem 5. Parse tags
You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.*/

namespace ParseTags
{
    using System;
    using System.Text.RegularExpressions;


    class ParseTag
    {
        static void Main()
        {
            Console.WriteLine("Please enter a text: ");
            string text = Console.ReadLine();
            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
        }
    }
}
