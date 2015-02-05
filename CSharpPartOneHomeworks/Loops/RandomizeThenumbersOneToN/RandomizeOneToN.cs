//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;

class RandomizeOneToN
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int numberN = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        Random randomGen = new Random();
        Console.Write("Randomize numbers [1...n]: ");

        for (int i = 0; i < numberN; i++)
        {
            numbers.Add(i + 1);
        }
        while (numbers.Count > 0)
        {
            int randomNum = randomGen.Next(0, numbers.Count);
            Console.Write(numbers[randomNum] + " ");
            numbers.RemoveAt(randomNum);
        }
        Console.WriteLine();
    }
}

