//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Linq;

class IntCalc
{
    static void Main()
    {
        Console.WriteLine("Please enter a set of numbers, separated by space:");
        int[] set = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        Console.WriteLine("\nMinimum is: " + CalculateMinimum(set));
        Console.WriteLine("Maximum is: " + CalculateMaximum(set));
        Console.WriteLine("Avarage is: " + CalculateAvarage(set));
        Console.WriteLine("Sum is: " + CalculationSum(set));
        Console.WriteLine("Product is: " + CalculationProduct(set));
    }

    static int CalculateMinimum(params int[] nums)
    {
        return nums.Min();
    }

    static int CalculateMaximum(params int[] nums)
    {
        return nums.Max();
    }

    static double CalculateAvarage(params int[] nums)
    {
        return nums.Average();
    }

    static long CalculationSum(params int[] nums)
    {
        return nums.Sum();
    }

    static long CalculationProduct(params int[] nums)
    {
        int prod = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            prod *= nums[i];
        }
        return prod;
    }
}

