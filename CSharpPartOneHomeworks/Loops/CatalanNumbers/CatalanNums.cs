//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNums
{
    static void Main()
    {
        Console.Write("Please e nter N: ");
        int numN = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialTwoN = 1;
        BigInteger factorialNPlusOne = 1;
        BigInteger result = 0;

        if (numN >= 0 && numN <= 100)
        {
            for (int i = 1; i <= 2 * numN; i++)
            {
                factorialTwoN *= i;
                if (i <= numN)
                {
                    factorialN *= i;
                }
                if (i <= (numN + 1))
                {
                    factorialNPlusOne *= i;
                }
            }
            result = factorialTwoN / (factorialNPlusOne * factorialN);
            Console.WriteLine("The result: " + result);
        }
        else 
        {
            Console.WriteLine("Please enter correct value for N!!!");
        }
    }
}

