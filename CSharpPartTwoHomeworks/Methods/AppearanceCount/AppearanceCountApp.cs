//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

public class AppearanceCountApp
{
    public static void Main()
    {
        Console.WriteLine("Please enter an array!");
        Console.Write("Please enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}] - ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter number, to check how many times it appears in: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("\nNumber {0} appers {1} times in this array.", k, AppearanceCount(numbers, k));
    }

    public static int AppearanceCount(int[] nums, int n)
    {
        int counter = 0;
        foreach (int num in nums)
        {
            if (num == n)
            {
                counter++;
            }
            else
            {
                continue;
            }
        }
        return counter;
    }
}

