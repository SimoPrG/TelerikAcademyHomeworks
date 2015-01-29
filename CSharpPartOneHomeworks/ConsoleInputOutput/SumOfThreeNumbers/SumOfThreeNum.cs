//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Threading;
using System.Globalization;

class SumOfThreeNum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter three real numbers!");
        Console.Write("Enter the first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        float sumOfNum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("The sum of the numbers is: " + sumOfNum);

    }
}

