//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int numK = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;
        int factorialNK = 1;

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
            for (int i = 1; i <= numN - numK; i++)
            {
                factorialNK *= i;
            }
            float expression = (float)factorialN / ((float)(factorialK * (float)factorialNK));
            Console.WriteLine("Result: " + expression);
        }
    }
}