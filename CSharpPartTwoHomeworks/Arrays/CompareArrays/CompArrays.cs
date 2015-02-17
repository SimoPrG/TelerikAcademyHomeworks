//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter first integer array, separated by space:");
        int[] numbersOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Please enter second integer array, separated by space:");
        int[] numbersTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        //int n = int.Parse(Console.ReadLine());
        //int[] numbersOne = new int[n];
        //int[] numbersTwo = new int[n];

        //Console.WriteLine("Please enter first array:");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("[{0}] = ", i);
        //    numbersOne[i] = int.Parse(Console.ReadLine()); 
        //}

        //Console.WriteLine("Please enter second array:");        
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("[{0}] = ", i);
        //    numbersTwo[i] = int.Parse(Console.ReadLine());
        //}

        int length = 0;
        bool isEqual = true;
        Console.WriteLine();

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

