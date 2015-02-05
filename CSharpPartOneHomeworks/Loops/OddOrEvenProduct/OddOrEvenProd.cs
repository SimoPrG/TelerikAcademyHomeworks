//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Linq;

class OddOrEvenProd
{
    static void Main()
    {
        Console.Write("Please enter n numbers separated by space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int evenProd = 1;
        int oddProd = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                evenProd *= numbers[i];
            }
            else
            {
                oddProd *= numbers[i];
            }
        }
        bool isItTrue = evenProd == oddProd;
        if (evenProd == oddProd)
        {
            Console.WriteLine("Product = " + evenProd);
        }
        else
        {
            Console.WriteLine("Even product = " + evenProd);
            Console.WriteLine("Odd product = " + oddProd);
        }
        Console.WriteLine("Result: {0}", isItTrue ? "Yes" : "No");
    }
}

