//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Collections.Generic;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter an array, separated by space!");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int currentSum = numbers[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = numbers[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += numbers[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;

                startIndex = tempStartIndex;
                endIndex = i;
            }
        }

        Console.WriteLine("The best sum is: {0} ", maxSum);
        Console.Write("The best sequence is:");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine("\b\b ");
    }
}

