//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//  input	        output
//  Hi!	            \u0048\u0069\u0021

using System;
using System.Text;

class UnicodeChars
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        var result = new StringBuilder();

        foreach (var letter in text)
        {
            result.Append(string.Format("\\u{0:X4}", (int)letter));
        }
        Console.WriteLine("\n" + result);
    }
}

