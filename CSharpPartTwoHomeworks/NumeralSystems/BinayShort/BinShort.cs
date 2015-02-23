//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinShort
{
    static void Main()
    {
        Console.Write("Please enter 16-bit signed integer: ");
        short number = short.Parse(Console.ReadLine());
        string sign = "0";
        if (number < 0)
        {
            sign = "1";
            number *= -1;
        }
        string remainders = "";
        string binNumber = "";
        if (number <= 0)
        {
            binNumber = "0";
        }
        while (number > 0)
        {
            remainders += (number % 2).ToString();
            number /= 2;
        }
        for (int i = remainders.Length - 1; i >= 0; i--)
        {
            binNumber += remainders[i];
        }
        Console.WriteLine("\nNmber in binary representation: " + sign + binNumber.PadLeft(15, '0'));
    }
}

