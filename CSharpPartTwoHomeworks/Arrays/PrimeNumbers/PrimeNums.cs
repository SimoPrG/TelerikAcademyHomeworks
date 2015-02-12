//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNums
{
    static void Main()
    {

        bool[] primes = new bool[10000000];

        for (long i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            if (primes[i] == false)
            {
                for (long j = i * i; j < primes.Length; j += i)
                {
                    primes[j] = true;
                }
            }
        }

        for (long i = 2; i < primes.Length; i++)
        {
            if (!primes[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}

