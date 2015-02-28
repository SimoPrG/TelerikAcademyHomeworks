//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OrderWordsApp
{
    static void Main()
    {
        Console.WriteLine("Enter a list of words, separated by space: ");
        string input = Console.ReadLine();
        var words = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        words = words.OrderBy(x => x).ToList();

        Console.WriteLine();

        foreach (var word in words)
        {
            Console.Write(word + ", ");
        }
        Console.WriteLine("\b\b  ");
    }
}

