//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
//Use two nested loops.

using System;

class MatrixOfNums
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number N: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Matrix of numbers:");
        if (0 <= num && num <= 20)
        {
            for (int row = 1; row <= num; row++)
            {

                for (int colum = row; colum < num + row; colum++)
                {
                    Console.Write(colum + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a correct value for n!!!");
        }
    }
}

