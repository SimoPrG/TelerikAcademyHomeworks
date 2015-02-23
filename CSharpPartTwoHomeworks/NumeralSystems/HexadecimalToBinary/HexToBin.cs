//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBin
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpperInvariant();
        string binNumber = "";
        Console.Write("\nThe number in binary representation: ");
        foreach (char sym in hexNumber)
        {
            switch (sym)
            {
                case '0': binNumber = "0000"; break;
                case '1': binNumber = "0001"; break;
                case '2': binNumber = "0010"; break;
                case '3': binNumber = "0011"; break;
                case '4': binNumber = "0100"; break;
                case '5': binNumber = "0101"; break;
                case '6': binNumber = "0110"; break;
                case '7': binNumber = "0111"; break;
                case '8': binNumber = "1000"; break;
                case '9': binNumber = "1001"; break;
                case 'A': binNumber = "1010"; break;
                case 'B': binNumber = "1011"; break;
                case 'C': binNumber = "1100"; break;
                case 'D': binNumber = "1101"; break;
                case 'E': binNumber = "1110"; break;
                case 'F': binNumber = "1111"; break;

            }
            Console.Write(binNumber + " ");
        }
        Console.WriteLine();
    }
}

