//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

public class LargerThanNeighboursApp
{
    public static void Main()
    {
        int[] numbers = { 5, 6, 1, 2, 8, 9, 7, 5, 1, 2, 3, 5, 6, 8, 4 };
        int indexElem = 5;

        Console.WriteLine("The number at position {0} is larger than its neighbours: {1}", indexElem, IsLarger(numbers, indexElem));
        
    }

    public static bool IsLarger(int[] nums, int index)
    {
        bool isLarger = false;
        if (index < 0 || index > nums.Length - 1)
        {
            isLarger = false;
        }
        else if (index == 0 || index == nums.Length - 1)
        {
            isLarger = false;
        }
        else
        {
            if (nums[index] > nums[index - 1] && nums[index] > nums[index + 1])
            {
                isLarger = true;
            }
            else
            {
                isLarger = false;

            }
        }
        return isLarger;
    }
}

