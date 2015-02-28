//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentencesApp
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a word:");
        string searchingWord = Console.ReadLine();

       //string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
       //string searchingWord = "in";
        
        Console.WriteLine();
        IsMatch(text, searchingWord);
    }

    static void IsMatch(string text, string searchingWord)
    {
        string[] sentences = text.Split(new char[] { '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.IsMatch(sentences[i], String.Format("{0}{1}{2}", "(^|[.;,:!? -])", searchingWord, "([.;,:!? -]|$)"), RegexOptions.IgnoreCase))
            {
                result.Append(string.Format("{0}. ", sentences[i].Trim()));
            }
        }
        if (result.ToString() == "")
        {
            Console.WriteLine("There is no match!");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}

