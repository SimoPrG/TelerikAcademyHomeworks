//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.

//Example:

//input	                                                output
//C# is not C++, not PHP and not Delphi!	            Delphi not and PHP, not C++ not is C#!

using System;
using System.Text;
using System.Linq;

class ReverseSentenceApp
{
    static string[] separators = { " ", ",", ".", ";", "!", "?", "-", ":" };

    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";

        string[] arrayInput = StringToArray(input);
        string[] result = new string[arrayInput.Length];

        FillPunctoation(arrayInput, result);
        ReverseSentence(arrayInput, result);

        Console.WriteLine(PrintSentence(result));

    }

    private static string PrintSentence(string[] result)
    {
        var finalResult = new StringBuilder();

        foreach (var word in result)
        {
            if (separators.Contains(word))
            {
                finalResult.Append(word);
            }
            else
            {
                finalResult.Append(" " + word);
            }
        }
        return finalResult.ToString().Trim();
    }

    private static string[] FillPunctoation(string[] arrayInput, string[] result)
    {
        for (int i = 0; i < arrayInput.Length; i++)
        {
            if (separators.Contains(arrayInput[i]))
            {
                result[i] = arrayInput[i];
            }
        }
        return result;
    }

    private static void ReverseSentence(string[] arryInput, string[] result)
    {
        for (int i = 0, j = result.Length - 1; i < result.Length && j >= 0; i++, j--)
        {
            while (result[i] != null)
            {
                i++;
            }
            while (separators.Contains(arryInput[j]))
            {
                j--;
            }
            result[i] = arryInput[j];
        }
    }

    private static string[] StringToArray(string input)
    {
        foreach (var sign in separators)
        {
            input = input.Replace(sign, (" " + sign + " "));
        }

        string[] arrySentence = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return arrySentence;
    }
}

