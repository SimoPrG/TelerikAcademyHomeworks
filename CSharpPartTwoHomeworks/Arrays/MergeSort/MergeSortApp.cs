//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;


class MergeSortApp
{
    static void Main()
    {
        int[] numbers = { 6, 8, 9, 5, 4, 7, 1, 25, 68, 97 };
        int[] tempNumbers = new int[numbers.Length];
        Console.WriteLine("The array before sorting: " + String.Join(", ", numbers));

        TopDownSplitMerge(numbers, 0, numbers.Length, tempNumbers);

        Console.WriteLine("The array after sorting: " + String.Join(", ", numbers));
    }
    static void TopDownSplitMerge(int[] nums, int iBegin, int iEnd, int[] sortNums)
    {
        if (iEnd - iBegin < 2)
        {
            return;
        }
        int iMiddle = (iEnd + iBegin) / 2;            
        TopDownSplitMerge(nums, iBegin, iMiddle, sortNums);  
        TopDownSplitMerge(nums, iMiddle, iEnd, sortNums);  
        TopDownMerge(nums, iBegin, iMiddle, iEnd, sortNums);  
        CopyArray(sortNums, iBegin, iEnd, nums);              
    }
    static void TopDownMerge(int[] nums, int iBegin, int iMiddle, int iEnd, int[] sortNums)
    {
        int i0 = iBegin, i1 = iMiddle;
        for (int j = iBegin; j < iEnd; j++)
        {

            if (i0 < iMiddle && (i1 >= iEnd || nums[i0] <= nums[i1]))
            {
                sortNums[j] = nums[i0];
                i0 = i0 + 1;
            }
            else
            {
                sortNums[j] = nums[i1];
                i1 = i1 + 1;
            }
        }
    }
    static void CopyArray(int[] sortNums, int iBegin, int iEnd, int[] nums)
    {
        for (int k = iBegin; k < iEnd; k++)
            nums[k] = sortNums[k];
    }
}

