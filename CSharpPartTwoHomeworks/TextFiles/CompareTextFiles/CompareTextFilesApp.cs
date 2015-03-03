//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of 
//lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFilesApp
{
    static void Main()
    {
        try
        {
            var readFileOne = new StreamReader(@"..\..\fileOne.txt");
            var readFileTwo = new StreamReader(@"..\..\fileTwo.txt");

            int countSame = 0;
            int countDifferent = 0;

            using (readFileOne)
            {
                string currLineOne = readFileOne.ReadLine();

                using (readFileTwo)
                {
                    string currLineTwo = readFileTwo.ReadLine();

                    while (currLineOne != null && currLineTwo != null)
                    {
                        if (currLineOne == currLineTwo)
                        {
                            countSame++;
                        }
                        else countDifferent++;
                        currLineOne = readFileOne.ReadLine();
                        currLineTwo = readFileTwo.ReadLine();
                    }
                }
            }
            Console.WriteLine("Count of same lines: {0} \nCounts of different lines: {1}", countSame, countDifferent);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}

