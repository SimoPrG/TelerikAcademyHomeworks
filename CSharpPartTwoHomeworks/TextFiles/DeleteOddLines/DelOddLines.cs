//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DelOddLines
{
    static void Main()
    {
        try
        {
            var reader = new StreamReader(@"..\..\file.txt");
            int count = 1;
            var evenLines = new StringBuilder();

            using (reader)
            {
                string currLine = reader.ReadLine();
                while (currLine != null)
                {
                    if (count % 2 == 0)
                    {
                        evenLines.AppendLine(currLine);
                    }
                    count++;
                    currLine = reader.ReadLine();
                }
            }

            var write = new StreamWriter(@"..\..\file.txt");

            using (write)
            {
                write.Write(evenLines);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

