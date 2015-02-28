//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

using System;
using System.Text;

class StrInCSharp
{
    static void Main()
    {
        StringBuilder newString = new StringBuilder();
        newString.AppendLine("*The strings are sequences of characters, \ndeclarated by the key word string in c#.");
        newString.AppendLine("String objects contain an immutable (read-only) sequence of characters.");
        newString.AppendLine("Strings use Unicode to support multiple languages and alphabets.");
        newString.AppendLine("*Strings are stored in the dynamic memory (managed heap),\nSystem.String is reference type. Srings have fixed length. ");
        Console.WriteLine(newString);

        Console.WriteLine("*Most important methods of the String class are: " + MostImportantMethods());
    }

    static string MostImportantMethods()
    {
        StringBuilder mostImp = new StringBuilder();

        mostImp.Append("Length, ");
        mostImp.Append("this[], ");
        mostImp.Append("\nCompare(str1, str2), ");
        mostImp.Append("IndexOf(str), ");
        mostImp.Append("LastIndexOf(str), ");
        mostImp.Append("\nSubstring(startIndex, length), ");
        mostImp.Append("\nReplace(oldStr, newStr), ");
        mostImp.Append("Remove(startIndex, length), ");
        mostImp.Append("ToLower(), ");
        mostImp.Append("ToUpper(), ");
        mostImp.Append("\nTrim()");

        return mostImp.ToString();
    }
}
