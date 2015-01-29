//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Threading;
using System.Globalization;

class TheBiggestOfFiveNums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter five numbers:");
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float thirdNumber = float.Parse(Console.ReadLine());
        float fourthNumber = float.Parse(Console.ReadLine());
        float fifthNumner = float.Parse(Console.ReadLine());
        Console.Write("The biggest number is: ");
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumner)
        {
            Console.Write(firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumner)
        {
            Console.Write(secondNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumner)
        {
            Console.Write(thirdNumber);
        }
        else if (fourthNumber >= firstNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= fifthNumner)
        {
            Console.Write(fourthNumber);
        }
        else if (fifthNumner >= firstNumber && fifthNumner >= secondNumber && fifthNumner >= thirdNumber && fifthNumner >= fourthNumber)
        {
            Console.Write(fifthNumner);
        }
        Console.WriteLine();
    }
}

