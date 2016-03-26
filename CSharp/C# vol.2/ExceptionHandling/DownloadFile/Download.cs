/* Problem 4. Download file
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.*/

namespace DownloadFile
{
    using System;
    using System.IO;
    using System.Net;


    class Download
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Content/Images/news-img01.png";
            string fileName = Path.GetFileName(url);
            using (WebClient myWebClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Start downloading {0}", url);
                    myWebClient.DownloadFile(url, fileName);
                    Console.WriteLine("Download succesfull.");
                    Console.WriteLine("You can find downloaded file in the local folder.");
                }
                catch (WebException ex)
                {
                    Console.Write(ex.Message);
                    if (ex.InnerException != null)
                        Console.WriteLine(" " + ex.InnerException.Message);
                    else
                        Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Some error. Details: " + ex.Message);
                }
            }
        }
    }
}
