//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighboursApp
{
    static void Main()
    {
        int[] numbers = { 3, 1, 2, 4, 1};
        int indexElem = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            indexElem = i;
            if (FindFirstLarger(numbers, indexElem) != -1)
            {
                Console.WriteLine("The first element larger than its neigbours is at position: " + i);
                return;
            }
        }
        Console.WriteLine("There is no such element!");
    }

    static int FindFirstLarger(int[] nums, int index)
    {
        if (LargerThanNeighboursApp.IsLarger(nums, index) == true)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
}

