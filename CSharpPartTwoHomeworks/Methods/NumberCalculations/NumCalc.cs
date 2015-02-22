//Problem 15.* Number calculations

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class NumCalc
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter a set of numbers, separated by space:");
        //int[] set = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //decimal[] set = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        //byte[] set = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
        float[] set = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();

        Console.WriteLine("\nMinimum is: " + CalculateMinimum(set));
        Console.WriteLine("Maximum is: " + CalculateMaximum(set));
        Console.WriteLine("Avarage is: " + CalculateAvarage(set));
        Console.WriteLine("Sum is: " + CalculationSum(set));
        Console.WriteLine("Product is: " + CalculationProduct(set));
    }

    static T CalculateMinimum<T>(params T[] nums)
    {
        return nums.Min();
    }

    static T CalculateMaximum<T>(params T[] nums)
    {
        return nums.Max();
    }

    static T CalculateAvarage<T>(params T[] nums)
    {
        dynamic sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum / nums.Length;
    }

    static T CalculationSum<T>(params T[] nums)
    {
        dynamic sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    static T CalculationProduct<T>(params T[] nums)
    {
        dynamic prod = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            prod *= nums[i];
        }
        return prod;
    }
}

