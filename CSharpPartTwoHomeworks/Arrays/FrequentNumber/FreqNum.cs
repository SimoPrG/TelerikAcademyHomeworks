//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;
using System.Linq;

class FreqNum
{
    static void Main()
    {
        Console.Write("Please enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array:");
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int count = 0;
        int maxCount = 0;
        int freqNum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                freqNum = numbers[i];
            }
            count = 0;
        }
        Console.WriteLine("The most frequent number is {0} ({1} times).", freqNum, maxCount);
    }
}

