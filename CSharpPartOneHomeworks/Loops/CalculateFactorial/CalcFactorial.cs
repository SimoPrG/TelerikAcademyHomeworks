//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class CalcFactorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int numK = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        if (numK > 1 && numN > numK && numN < 100)
        {
            for (int i = 1; i <= numN; i++)
            {
                factorialN *= i;

                if (i <= numK)
                {
                    factorialK *= i;
                }
            }

            BigInteger factorial = factorialN / factorialK;
            Console.WriteLine("Factotial N / K = {0}", factorial);
        }
        else 
        {
            Console.WriteLine("Enter a correct values for n and k!!!");
        }
    }
}

