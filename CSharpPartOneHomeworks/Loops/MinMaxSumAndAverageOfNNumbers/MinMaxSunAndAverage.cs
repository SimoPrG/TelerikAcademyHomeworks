//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class MinMaxSumAndAverage
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter count of numbers: ");
        int countOfN = int.Parse(Console.ReadLine());

        if (countOfN < 0)
        {
            Console.WriteLine("Invalid count of numbers!!!");
            return;
        }

        Console.WriteLine("Enter each of numbers on separate lines:");
        int[] numbers = Enumerable.Range(0, countOfN).Select(x => int.Parse(Console.ReadLine())).ToArray();

        Console.WriteLine("Min = {0}", numbers.Min());
        Console.WriteLine("Max = {0}", numbers.Max());
        Console.WriteLine("Sum = {0}", numbers.Sum());
        Console.WriteLine("Avarage = {0:0.00}", numbers.Average());

    }
}