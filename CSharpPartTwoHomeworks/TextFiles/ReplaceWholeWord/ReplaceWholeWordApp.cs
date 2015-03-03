//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWordApp
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
                        currLine = currLine.ToLower();
                        currLine = Regex.Replace(currLine, @"\bstart\b", "finish");
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

