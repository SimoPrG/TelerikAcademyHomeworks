//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexLetter
{
    static void Main()
    {
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        int[] letters = new int[26];
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[i - 65] = i; 
        }

        foreach (char letter in word)
        {
            Console.WriteLine("Index of \"{0}\" is {1}.", letter, Array.IndexOf(letters, char.ToUpperInvariant(letter))); 
        }
    }
}

