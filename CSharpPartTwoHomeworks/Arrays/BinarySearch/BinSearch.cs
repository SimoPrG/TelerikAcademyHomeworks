//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class BinSearch
{
    static void Main()
    {
        Console.Write("Please enter values of array, separated by space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.Write("Please enter an element of the array: ");
        int element = int.Parse(Console.ReadLine());


        Array.Sort(numbers);
        Console.WriteLine("The array after sorting:" + String.Join(", ", numbers));

        int index = BinarySearch(numbers, element, 0, numbers.Length - 1);

        if (index != -1) Console.WriteLine("Number {0} found at index: {1}", element, index);
        else Console.WriteLine("Number {0} not found!", element);

    }
    private static int BinarySearch(int[] nums, int elem, int startIndex, int endIndex)
    {
        if (endIndex < startIndex)
        {
            return -1;
        }
        else
        {
            int midIndex = (startIndex + endIndex) / 2;

            if (nums[midIndex] > elem)
            {
                return BinarySearch(nums, elem, startIndex, midIndex - 1);
            }
            else if (nums[midIndex] < elem)
            {
                return BinarySearch(nums, elem, midIndex + 1, endIndex);
            }
            else
            {
                return midIndex;
            }
        }
    }
}

