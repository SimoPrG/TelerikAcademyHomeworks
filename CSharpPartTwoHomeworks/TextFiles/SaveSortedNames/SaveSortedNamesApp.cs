//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	            output.txt
//Ivan                  George
//Peter                 Ivan
//Maria                 Maria 
//George	            Peter

using System;
using System.IO;
using System.Text;
using System.Linq;

class SaveSortedNamesApp
{
    static void Main()
    {
        try
        {
            var reader = new StreamReader(@"..\..\input.txt");
            var output = new StreamWriter(@"..\..\output.txt");
            var readInput = new StringBuilder();

            using (reader)
            {
                string currLine = reader.ReadLine();

                while (currLine != null) 
                {
                    readInput.Append(currLine + " ");
                    currLine = reader.ReadLine();
                }
            }
            string[] arr = readInput.ToString().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(arr);
            using (output)
            {
                foreach (var word in arr)
                {
                    output.WriteLine(word);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

