//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;

class LettersCountApp
{
    static char[] separators = { ' ', ',', '.', '?', '!' };

    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();
        text = text.ToLower();

        CountingLetters(text);
    }

    static void CountingLetters(string text)
    {
        var letters = new Dictionary<char, int>();

        foreach (var letter in text)
        {
            if (!separators.Contains(letter))
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
        }
        Print(letters);
    }

    static void Print(Dictionary<char, int> letters)
    {
        Console.WriteLine();

        foreach (var letter in letters)
        {
            Console.WriteLine("{0} --> {1} times.", letter.Key, letter.Value);
        }
    }
}

