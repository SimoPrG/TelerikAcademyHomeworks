//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binNumber = Console.ReadLine();
        int decNumber = 0;

        for (int i = 0; i < binNumber.Length; i++)
        {
            decNumber += (int.Parse(binNumber[i].ToString()) * (int)Math.Pow(2, binNumber.Length - 1 - i));
        }
        Console.WriteLine("Number in decimal representation: " + decNumber);
    }
}

