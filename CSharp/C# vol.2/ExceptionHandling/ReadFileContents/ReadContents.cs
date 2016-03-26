﻿/* Problem 3. Read file contents
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.*/

namespace ReadFileContents
{

    using System;
    using System.Net;
    using System.IO;
    class ReadContents
    {
        
        static void Main()
        {
            Console.Write("Please enter full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader stream = new StreamReader(path))
                {
                    Console.WriteLine(stream.ReadToEnd());
                }
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
