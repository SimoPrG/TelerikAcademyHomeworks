//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class SumOfNNums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter number \"n\": ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter more \"n\" numbers, separated by space: ");
        float[] numbers = Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray<float>();
        float sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];     
        }
        Console.WriteLine("The sum is: " + sum);
    }
}

