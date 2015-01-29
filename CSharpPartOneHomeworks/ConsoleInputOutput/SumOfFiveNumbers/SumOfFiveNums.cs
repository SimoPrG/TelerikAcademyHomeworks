//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.


using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class SumOfFiveNums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter five numbers, separatet by a space: ");
        float[] numbers = Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray<float>();
        if (numbers.Length != 5) 
        {
            Console.WriteLine("Please enter five numbers!!!");
            return;
        }
        float sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
        Console.WriteLine("The sum of numbers is: {0}", sum);
    }
}

