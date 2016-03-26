/* Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.*/

using System;
using System.Text.RegularExpressions;

namespace ExtractHTML
{
    class HTMLExtract
    {
        static void Main()
        {
            const string htmlDoc = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            foreach (Match item in Regex.Matches(htmlDoc, "(?<=^|>)[^><]+?(?=<|$)"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();
            //
            //StringBuilder noTags = new StringBuilder();
            //
            //bool openTag = false;
            //
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == '<')
            //    {
            //        openTag = true;
            //    }
            //
            //    if (!openTag)
            //    {
            //        noTags.Append(text[i]);
            //
            //        if (text[i + 1] == '<')
            //        {
            //            noTags.AppendLine();
            //        }
            //    }
            //
            //    if (text[i] == '>')
            //    {
            //        openTag = false;
            //    }
            //}
            //
            //Console.WriteLine(noTags.ToString().Trim());

        }
    }
}