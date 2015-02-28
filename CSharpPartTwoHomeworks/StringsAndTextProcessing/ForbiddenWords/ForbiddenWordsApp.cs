//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//
//Example text: Microsoft announced its next generation PHP compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on 
//.NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Linq;
using System.Text.RegularExpressions;

class ForbiddenWordsApp
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter forbidden words, separated by space or comma:");
        string forbiddenWords = Console.ReadLine();

        Console.WriteLine(ReplaceForbiddenWords(text, forbiddenWords));
    }

    static string ReplaceForbiddenWords(string text, string forbiddenWords)
    {
        string[] forbidden = forbiddenWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

        for (int i = 0; i < forbidden.Length; i++)
        {
            text = Regex.Replace(text, forbidden[i], new string('*', forbidden[i].Length), RegexOptions.IgnoreCase);
        }
        return text;
    }
}

