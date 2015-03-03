//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLinesApp
{
    static void Main()
    {
        try
        {
            using (var file = new StreamReader(@"..\..\file.txt"))
            {
                string[] text = file.ReadToEnd().Split('\n');

                for (int i = 0; i < text.Length; i++)
                {
                    if ((i + 1) % 2 != 0)
                    {
                        Console.WriteLine(text[i]);
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

