//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;
using System.Linq;

class Program
{
    static char[] trimmers = { ',', '.', '!', '?', ':', ';', '-', '/', '\\' };

    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Plendromes: " + FindPalindromes(text));
       
    }

    static string FindPalindromes(string text)
    {
        string[] textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim(trimmers)).ToArray();
        var palendromes = new StringBuilder();

        foreach (var word in textArr)
        {

            if (word.Length > 1 && word == ReverseWords(word))
            {
                palendromes.Append(word + ", ");
            }
        }
        if (palendromes.Length == 0)
        {
            palendromes.Append("Not found!");
        }
        return palendromes.ToString();
    }

    static string ReverseWords(string word)
    {
        var revWord = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            revWord.Append(word[i]);
        }
        return revWord.ToString();
    }
}

