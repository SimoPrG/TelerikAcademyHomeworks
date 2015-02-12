//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArrayApp
{
    static void Main()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }
        foreach (int num in numbers)
        {
            Console.Write(num + ", ");
        }
        Console.Write("\b\b ");
        Console.WriteLine();
    }
}
