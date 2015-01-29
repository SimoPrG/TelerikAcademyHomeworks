//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
using System.Threading;
using System.Globalization;

class MultiplicationSignApp
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter three real numbers:");
        Console.Write("a = ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float thirdNumber = float.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The sign is: 0");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign is: -");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber  > 0)
        {
            Console.WriteLine("The sign is: +");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign is: -");            
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign is: +");                        
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign is: +");                        
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign is: +");                        
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign is: +");                        
        }
    }
}

