//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//  input	    output
//  sample	    elpmas

using System;
using System.Text;

class ReverseStr
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        Console.WriteLine(ReverseString(inputStr));
    }

    static string ReverseString(string str)
    {
        var reverseStr = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverseStr.Append(str[i]);
        }
        return reverseStr.ToString();
    }
}

