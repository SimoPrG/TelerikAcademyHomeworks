//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");        
        int n2 = int.Parse(Console.ReadLine());
        int num1 = Math.Abs(n1);
        int num2 = Math.Abs(n2);
        while (num1 != 0 && num2 != 0)
        {
            if (num1 > num2)
            {
                num1 -= num2;
            }
            else
            {
                num2 -= num1;
            }
        }
        Console.WriteLine("GCD: " + Math.Max(num1, num2));
    }
}

