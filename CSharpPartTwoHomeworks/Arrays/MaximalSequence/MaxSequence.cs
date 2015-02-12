//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class MaxSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter elements of the array in one line, separated by ','!");
        int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int sequence = 1;
        int maxSequence = 0;
        int num = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1 && array[i] == array[i + 1])
            {
                sequence++;
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    num = array[i];
                }
                else
                {
                    continue;
                }
            }
            else
            {
                sequence = 1;  
            }
        }
        int[] nums = new int[maxSequence];
        for (int i = 0; i < maxSequence; i++)
        {
            nums[i] = num;
        }
        Console.WriteLine(String.Join(", ", nums));
    }
}

