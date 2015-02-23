//Problem 6. Binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHex
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string hexNumber = Console.ReadLine().PadLeft(4, '0');
        string binNumber = "";
        Console.Write("\nThe number in hexadecimal representation: ");
        
        if (hexNumber.Length % 4 != 0)
        {
            for (int i = 0; i < hexNumber.Length % 4; i++)
            {
                hexNumber = "0" + hexNumber;
            }
        }

        for (int i = 0; i < hexNumber.Length; i += 4)
        {
            for (int j = i; j < i + 4; j++)
            {
                binNumber += hexNumber[j];
            }
            switch (binNumber)
            {
                case "0000": binNumber = "0"; break;
                case "0001": binNumber = "1"; break;
                case "0010": binNumber = "2"; break;
                case "0011": binNumber = "3"; break;
                case "0100": binNumber = "4"; break;
                case "0101": binNumber = "5"; break;
                case "0110": binNumber = "6"; break;
                case "0111": binNumber = "7"; break;
                case "1000": binNumber = "8"; break;
                case "1001": binNumber = "9"; break;
                case "1010": binNumber = "A"; break;
                case "1011": binNumber = "B"; break;
                case "1100": binNumber = "C"; break;
                case "1101": binNumber = "D"; break;
                case "1110": binNumber = "E"; break;
                case "1111": binNumber = "F"; break;

            }
                    Console.Write(binNumber);
                    binNumber = "";
        }

        Console.WriteLine();
    }
}

