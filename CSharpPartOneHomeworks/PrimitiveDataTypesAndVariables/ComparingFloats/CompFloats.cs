//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class CompFloats
{
    static void Main()
    {
        Console.WriteLine("Please enter the floatung-point (double) numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a - b < 0.000001)
            {
                Console.WriteLine("The entered numbers are equal!");
            }
            else
            {
                Console.WriteLine("The entered numbers are not equal!");
            }
        }
        else
        {
            if (b - a < 0.000001)
            {
                Console.WriteLine("The entered numbers are equal!");
            }
            else
            {
                Console.WriteLine("The entered numbers are not equal!");
            }
        }
    }
}

