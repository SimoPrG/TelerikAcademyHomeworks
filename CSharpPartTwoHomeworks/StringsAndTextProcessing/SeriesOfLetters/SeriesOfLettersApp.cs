//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                            output
//aaaaabbbbbcdddeeeedssaa	        abcdedsa

using System;
using System.Text;
using System.Linq;

class SeriesOfLettersApp
{
    static void Main()
    {
        string text = Console.ReadLine();

        Console.WriteLine(ReplaceSeries(text));
    }

    static string ReplaceSeries(string text)
    {
        var result = new StringBuilder();
        char lastLetter = ' ';

        foreach (var letter in text)
        {
            if (char.IsLetter(letter) && letter != lastLetter)
            {
                result.Append(letter);
                lastLetter = letter;
            }
        }
        if (result.Length == 0)
        {
            result.Append("Not found!");
        }
        return result.ToString();
    }
}
