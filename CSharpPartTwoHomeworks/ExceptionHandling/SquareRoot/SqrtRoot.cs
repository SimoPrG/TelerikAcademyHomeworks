//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SqrtRoot
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            FindSqrtRoot(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }

    static double FindSqrtRoot(int num)
    {
        if (num < 0)
        {
            throw new FormatException();
        }
        return Math.Sqrt(num);
    }
}

