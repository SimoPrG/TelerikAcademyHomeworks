//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbersApp
{
    static void Main()
    {
        try
        {
            var reader = new StreamReader(@"..\..\fileForRead.txt");
            var result = new StreamWriter(@"..\..\resultFile.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int count = 1;

                using (result)
                {
                    while (line != null)
                    {
                        result.WriteLine("{0:D2}. {1}", count, line);
                        line = reader.ReadLine();
                        count++;
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

