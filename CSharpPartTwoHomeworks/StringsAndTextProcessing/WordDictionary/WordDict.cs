//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//  input	            output
//  .NET	            platform for applications from Microsoft
//  CLR	                managed execution environment for .NET
//  namespace	        hierarchical organization of classes

using System;
using System.Linq;
using System.Collections.Generic;

class WordDict
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Please enter a word: ");
            string input = Console.ReadLine();

            Console.WriteLine("\n{0} --> {1}", input, MyDictionary(input));
        }
    }

    static string MyDictionary(string key)
    {
        key = key.ToLower();
        var dict = new Dictionary<string, string>();

        dict[".net"] = "platform for application from Microsoft";
        dict["clr"] = "managed execution environment for .NET";
        dict["namespace"] = "hierarchial organization of classes";
        dict["msdn"] = "microsoft developer network";
        dict["ide"] = "integrated development environment";

        if (dict.ContainsKey(key))
        {
            return dict[key];
        }
        else
        {
            return "No match!";
        }
    }
}

