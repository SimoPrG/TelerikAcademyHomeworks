//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxKSum
{
    static void Main()
    {
        Console.Write("Please enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number K: ");
        int k = int.Parse(Console.ReadLine());
        int[] numbrs = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbrs[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbrs);
        Console.WriteLine("The {0} elements that have maximal sum: ", k);

        for (int i = 0; i < k; i++)
        {
            Console.Write("{0}, ", numbrs[n - 1 - i]);
        }

    }
}

