//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubStringApp
{
    static void Main()
    {
        try
        {
            var input = new StreamReader(@"..\..\input.txt");
            var output = new StreamWriter(@"..\..\output.txt");

            using (input)
            {
                string currLine = input.ReadLine();
                using (output)
                {
                    while (currLine != null)
                    {
                        currLine = currLine.ToLower().Replace("start", "finish");
                        output.Write(currLine);
                        currLine = input.ReadLine();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

