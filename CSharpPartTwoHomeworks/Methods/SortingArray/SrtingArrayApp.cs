//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;

class SrtingArrayApp
{
    static void Main()
    {
        Console.WriteLine("Please enter an array, in single line, separated by space!");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("Please enter start index: ");
        int startIndex = int.Parse(Console.ReadLine());

        if (startIndex < 0 || startIndex >= numbers.Length)
        {
            Console.WriteLine("\nWrong start index, try again!");
            return;
        }

        int max = GetMaxElemOfPortionOfArray(numbers, startIndex);
        Console.WriteLine("\nMaximal element is: " + max);
        Console.WriteLine("Array in ascending order: " + string.Join(" ", SortArrayAscendingOrder(numbers, startIndex)));
        Console.WriteLine("Array in descending order: " + string.Join(" ", SortArrayDescendingOrder(numbers, startIndex)));
    }

    static int GetMaxElemOfPortionOfArray(int[] numbers, int startInd)
    {
        int tmpMax = 0;
        int max = 0;
        for (int i = startInd; i < numbers.Length; i++)
        {
            tmpMax = numbers[i];
            if (tmpMax >= max)
            {
                max = tmpMax;
            }
        }
        return max;
    }

    static int[] SortArrayAscendingOrder(int[] nums, int start)
    {
        int index = 0;
        int[] portionOfArray = new int[nums.Length - start];
        for (int i = start; i < nums.Length; i++)
        {
            portionOfArray[index] = nums[i];

            if (index < portionOfArray.Length)
            {
                index++;
            }
        }
        Array.Sort(portionOfArray);
        return portionOfArray;
    }

    static int[] SortArrayDescendingOrder(int[] nums, int start)
    {
        int[] numbers = SortArrayAscendingOrder(nums, start);
        Array.Reverse(numbers);
        return numbers;
    }
}

