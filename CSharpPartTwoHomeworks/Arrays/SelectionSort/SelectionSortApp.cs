//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSortApp
{
    static void Main()
    {
        Console.Write("Please enter an array to sorting, separated by space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("Before sorting: ");
        Console.WriteLine(string.Join(", ", numbers));


        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int tempI = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[tempI])
                {
                    tempI = j;
                }
            }
            int swap = numbers[i];
            numbers[i] = numbers[tempI];
            numbers[tempI] = swap;
        }

        Console.Write("After sorting: ");
        Console.WriteLine(string.Join(", ", numbers));
    }
}

