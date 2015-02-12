//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;

class FindSumInArrayApp
{
    static void Main()
    {
        Console.Write("Please enter an array, separated by space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sumForChek = int.Parse(Console.ReadLine());
        int startIndex = 0;
        int endIndex = 0;
        int tempSum = 0;
        bool broke = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                tempSum += numbers[j];
                if (tempSum > sumForChek)
                {
                    tempSum = 0;
                    break;
                }
                else if (tempSum == sumForChek)
                {
                    startIndex = i;
                    endIndex = j;
                    broke = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (broke)
            {
                break;   
            }
            if (i == numbers.Length - 1)
            {
                Console.WriteLine("There is not a sequence of given sum {0}.", sumForChek);
                return;
            }
        }
        for (int k = startIndex; k <= endIndex; k++)
        {
            Console.Write("{0}, ", numbers[k]);
        }
        Console.WriteLine("\b\b ");
    }
}

