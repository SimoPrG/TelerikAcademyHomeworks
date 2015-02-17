//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;


class QuickSortApp
{
    static void Main()
    {
        int[] numbers = { 1, 4, 7, 8, 9, 1, 2, 5, 7, 45, 12, 1, 2, 5, 8 };
        //Console.Write("Please enter values of an array, separated by space: ");
        //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("The array before sorting: " + String.Join(", ", numbers));
        QuickSort(numbers, 0, numbers.Length - 1);
        Console.WriteLine("The array after sorting: " + String.Join(", ", numbers));

    }
    static void QuickSort(int[] nums, int left, int right)
    {
        int l = left, r = right;
        int pivot = nums[(left + right) / 2];

        while (l <= r)
        {
            while (nums[l] < pivot)
            {
                l++;
            }

            while (nums[r] > pivot)
            {
                r--;
            }

            if (l <= r)
            { 
                int swap = nums[l];
                nums[l] = nums[r];
                nums[r] = swap;

                l++;
                r--;
            }
        }

        if (left < r)
        {
            QuickSort(nums, left, r);
        }

        if (l < right)
        {
            QuickSort(nums, l, right);
        }
    }
}

