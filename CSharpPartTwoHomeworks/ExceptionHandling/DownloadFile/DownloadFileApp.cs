//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

class DownloadFileApp
{
    static void Main()
    {
        string downloadDir = @"c:\image.png";

        try
        {
            var downloadFile = new WebClient();
            downloadFile.DownloadFile(@"http://telerikacademy.com/Content/Images/news-img01.png", downloadDir);
            Console.WriteLine(@"Downloaded file location is: {0}", downloadDir);

        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Undefined error!");
        }
    }
}

