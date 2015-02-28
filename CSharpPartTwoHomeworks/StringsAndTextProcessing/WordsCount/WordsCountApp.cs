//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the string along with 
//information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;

class WordsCountApp
{
    static char[] separators = { ' ', ',', '.', '?', '!' };

    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();
        text = text.ToLower();
        string[] textArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        CountingLetters(textArr);
    }

    static void CountingLetters(string[] textArr)
    {
        var letters = new Dictionary<string, int>();

        foreach (var letter in textArr)
        {
            if (!letters.ContainsKey(letter))
            {
                letters.Add(letter, 1);
            }
            else
            {
                letters[letter] += 1;
            }
        }
        Print(letters);
    }

    static void Print(Dictionary<string, int> letters)
    {
        Console.WriteLine();

        foreach (var letter in letters)
        {
            Console.WriteLine("{0} --> {1} times.", letter.Key, letter.Value);
        }
    }
}


