//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
//each on a single line.

using System;

class NumFromOneToN
{
    static void Main()
    {
        Console.Write("Please enter the integer number \"n\": ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers in the interval [1..n]:");
        for (int numbers = 1; numbers <= n; numbers++)
        {
            Console.WriteLine(numbers); 
        }
    }
}
