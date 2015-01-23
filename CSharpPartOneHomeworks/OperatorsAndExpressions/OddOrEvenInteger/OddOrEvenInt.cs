//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenInt
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int numForCheck = int.Parse(Console.ReadLine());
        bool isItTrue = numForCheck > 0 && numForCheck % 2 == 0;
        Console.WriteLine("Number is odd? {0}", isItTrue );
    }
}
