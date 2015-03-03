//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;


class ConcatenateTxtFiles
{
    static void Main()
    {
        Encoding encodingCyr = Encoding.GetEncoding(1251);
        try
        {
            var fileOne = new StreamReader(@"..\..\fileOne.txt", encodingCyr);
            var fileTwo = new StreamReader(@"..\..\fileTwo.txt", encodingCyr);
            var result = new StreamWriter(@"..\..\resultFile.txt", false, encodingCyr);

            string fileOneRead = string.Empty;
            string fileTwoRead = string.Empty;
            string resultWrite = string.Empty;

            using (fileOne)
            {
               fileOneRead = fileOne.ReadToEnd();
            }
            using (fileTwo)
            {
                fileTwoRead = fileTwo.ReadToEnd();
            }
            using (result)
            {
                result.WriteLine(fileOneRead);
                result.WriteLine(fileTwoRead);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

