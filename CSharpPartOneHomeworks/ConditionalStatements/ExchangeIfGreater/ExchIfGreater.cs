//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one 
//is greater than the second one. As a result print the values a and b, separated by a space.

using System;
using System.Threading;
using System.Globalization;

class ExchIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter two numbers: ");
        Console.Write("a = ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("The result is: ");
        if (firstNumber > secondNumber)
        {
            Console.WriteLine(secondNumber + " " + firstNumber);
        }
        else
        {
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
    }
}

