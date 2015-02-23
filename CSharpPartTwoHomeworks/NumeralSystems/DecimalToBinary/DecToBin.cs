//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecToBin
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int decNumber = int.Parse(Console.ReadLine());
        string remainders = "";
        string binNumber = "";
        if (decNumber <= 0)
        {
            binNumber = "0";
        }
        while (decNumber > 0)
        {
            remainders += (decNumber % 2).ToString();
            decNumber /= 2;
        }
        for (int i = remainders.Length - 1; i >= 0; i--)
        {
            binNumber += remainders[i];
        }
        Console.WriteLine("\nNmber in binary representation: " + binNumber);
    }
}

