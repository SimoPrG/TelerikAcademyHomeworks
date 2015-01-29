//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter three numbers:");
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float thirdNumber = float.Parse(Console.ReadLine());
        Console.Write("The biggest number is: ");
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.Write(firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            Console.Write(secondNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            Console.Write(thirdNumber);
        }
        Console.WriteLine();
    }
}
