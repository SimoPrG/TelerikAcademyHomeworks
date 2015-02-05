//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers: ");
        Console.Write("n = ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("Random numbers [min...max]: ");
        Random randomGen = new Random();
        if (min != max)
        {
            if (min > max)
            {
                int var = min;
                min = max;
                max = var;
            }
            for (int i = 0; i < numberN; i++)
            {
                Console.Write(randomGen.Next(min, max + 1) + " ");
            }
        }
        else
        {
            Console.WriteLine("Max and min can't be equal!!!");
        }
        Console.WriteLine();
    }
}
