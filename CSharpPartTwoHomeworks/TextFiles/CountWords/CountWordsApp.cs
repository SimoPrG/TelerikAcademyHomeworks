//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times 
//each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text;
using System.Linq;

class CountWordsApp
{
    static void Main()
    {
        try
        {
            string testRead = string.Empty;
            string wordsRead = string.Empty;

            using (var test = new StreamReader(@"..\..\test.txt"))
            {
                testRead = test.ReadToEnd().ToLower();
            }

            using (var words = new StreamReader(@"..\..\words.txt"))
            {
                wordsRead = words.ReadToEnd().ToLower();
            }
            using (var result = new StreamWriter(@"..\..\result.txt"))
            {
                result.WriteLine(FindCount(testRead, wordsRead));
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static string FindCount(string test, string words)
    {
        var result = new StringBuilder();
        string[] wordsArr = words.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
        int count = 0;

        for (int i = 0; i < wordsArr.Length; i++)
        {
            string currTest = test;
            do
            {
                if (currTest.Contains(wordsArr[i]))
                {
                    count++;
                    currTest = currTest.Substring(currTest.IndexOf(wordsArr[i]) + 1);
                }
            }
            while (currTest.Contains(wordsArr[i]));

            result.AppendLine(wordsArr[i] + " - " + count + " times.");
            count = 0;
        }
        return result.ToString();
    }
}

