//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//     input	                output
//"43 68 9 23 318"	             461

using System;
using System.Linq;

class SumInt
{
    static void Main()
    {
        Console.Write("Please enter a sequence, separted by space: ");
        string sequence = Console.ReadLine();

        Console.WriteLine("\nThe sum of sequence is: " + FindSum(sequence));
    }

    static int FindSum(string sequence)
    {
        int[] sequenceArr = sequence.Split(' ').Select(int.Parse).ToArray();
        int sum = sequenceArr.Sum();
        return sum;
    }
}

