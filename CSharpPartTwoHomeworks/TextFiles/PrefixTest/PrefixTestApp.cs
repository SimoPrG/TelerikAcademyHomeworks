//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTestApp
{
    static void Main()
    {
        try
        {
            using (var input = new StreamReader(@"..\..\input.txt"))
            {
                string currLine = input.ReadLine();

                using (var output = new StreamWriter(@"..\..\output.txt"))
                {
                    while (currLine != null)
                    {
                        currLine = currLine.ToLower();
                        currLine = Regex.Replace(currLine, @"\btest\w*\b", string.Empty);
                        output.WriteLine(currLine);
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

