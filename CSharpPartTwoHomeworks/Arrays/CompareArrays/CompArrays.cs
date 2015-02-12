//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter two integer arrays to compares, separated by space:");
        int[] numbersOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] numbersTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int length = 0;
        bool isEqual = true;

        if (numbersOne.Length == numbersTwo.Length)
        {
            length = numbersOne.Length;
        }
        else
        {
            Console.WriteLine("Arrays are not equal!");
            return;
        }

        for (int i = 0; i < length; i++)
        {
            if (numbersOne[i] == numbersTwo[i])
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
                break;
            }
        }
        Console.WriteLine("Arrays {0} equal!", isEqual ? "are" : "are not");
    }
}

