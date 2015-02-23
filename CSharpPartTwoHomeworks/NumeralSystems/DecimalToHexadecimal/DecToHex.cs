//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int decNumber = int.Parse(Console.ReadLine());
        int divRem = 0;
        string remainders = "";
        string binNumber = "";
        if (decNumber <= 0)
        {
            binNumber = "0";
        }
        while (decNumber > 0)
        {
            divRem = decNumber % 16;
            decNumber /= 16;
            if (divRem > 9)
            {
                switch (divRem)
                {
                    case 10: remainders += "A"; break;
                    case 11: remainders += "B"; break;
                    case 12: remainders += "C"; break;
                    case 13: remainders += "D"; break;
                    case 14: remainders += "E"; break;
                    case 15: remainders += "F"; break;

                    default: break;
                }
            }
            else
            {
                remainders += divRem.ToString();
            }
        }
        for (int i = remainders.Length - 1; i >= 0; i--)
        {

            binNumber += remainders[i];
        }
        Console.WriteLine("\nNmber in hexadecimal representation: " + binNumber);
    }
}

