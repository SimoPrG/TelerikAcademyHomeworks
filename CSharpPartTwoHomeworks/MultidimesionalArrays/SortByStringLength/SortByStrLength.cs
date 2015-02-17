//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortByStrLength
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        string[] arrayStr = new string[n];

        //string[] arrayStr = { "ho", "xxxxxx", "hah", "tititit", "fofuuu" };

        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}] --> ", i);
            arrayStr[i] = Console.ReadLine();
        }
        Console.WriteLine("\nThe array, sorted by the length of its elements.");
        Array.Sort(arrayStr, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine(string.Join(", ", arrayStr));
    }
}
