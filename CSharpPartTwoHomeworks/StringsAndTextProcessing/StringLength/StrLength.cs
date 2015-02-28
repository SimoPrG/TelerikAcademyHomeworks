//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StrLength
{
    static void Main()
    {
        Console.WriteLine("Enter a string (maximum 20 characters):");
        string text = Console.ReadLine().PadRight(20, '*');
        if (text.Length > 20)
        {
            Console.WriteLine("Out of range!");
            return;
        }
        Console.WriteLine(text);
    }
}

