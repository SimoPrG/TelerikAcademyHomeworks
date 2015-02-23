//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpperInvariant();
        int tmpVal = 0;
        int decNumber = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case 'A': tmpVal = 10; break;
                case 'B': tmpVal = 11; break;
                case 'C': tmpVal = 12; break;
                case 'D': tmpVal = 13; break;
                case 'E': tmpVal = 14; break;
                case 'F': tmpVal = 15; break;

                default: tmpVal = int.Parse(hexNumber[i].ToString()); break;
            }
            decNumber += (tmpVal * (int)Math.Pow(16, hexNumber.Length - 1 - i));

        }
        Console.WriteLine("\nNumber in decimal representation: " + decNumber);
    }
}

