//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;
using System.Collections.Generic;

class IncSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter elements of the array in one line, separated by ','!");
        int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int sequence = 1;
        List<int> tempNums = new List<int>();
        List<int> num = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1 && array[i] + 1 == array[i + 1])
            {
                if (sequence == 1)
                {
                    num.Add(array[i]);
                }
                sequence++;
                num.Add(array[i + 1]);
            }
            else
            {
                sequence = 1;
                if (num.Count > tempNums.Count)
                {
                    tempNums.Clear();
                    num.ForEach(x => tempNums.Add(x));
                }
                num.Clear();
            }
        }
        tempNums.TrimExcess();
        Console.WriteLine(String.Join(", ", tempNums));
    }
}

