//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystem
{
    static void Main()
    {
        Console.Write("Enter a base of numeral system, to convert from: ");
        byte s = byte.Parse(Console.ReadLine());
        Console.Write("Enter a base of numeral system, to convert to: ");
        byte d = byte.Parse(Console.ReadLine());
        if (Validation(s, d) == false)
        {
            Console.WriteLine("\nIncorrect numeral system!");
            return;
        }
        Console.Write("Enter your number: ");
        string number = Console.ReadLine().ToUpperInvariant();
        Console.WriteLine("\nResult is: " + DecToX(XToDec(number, s), d));
    }

    static int XToDec(string num, byte s)
    {
        int decNumber = 0;
        int tmpVal = 0;
        for (int i = 0; i < num.Length; i++)
        {
            switch (num[i])
            {
                case 'A': tmpVal = 10; break;
                case 'B': tmpVal = 11; break;
                case 'C': tmpVal = 12; break;
                case 'D': tmpVal = 13; break;
                case 'E': tmpVal = 14; break;
                case 'F': tmpVal = 15; break;

                default: tmpVal = int.Parse(num[i].ToString()); break;
            }
            decNumber += (tmpVal * (int)Math.Pow(s, num.Length - 1 - i));
        }
        return decNumber;
    }

    static string DecToX(int num, byte d)
    {
        int divRem = 0;
        string remainders = "";
        string result = "";
        if (num <= 0)
        {
            result = "0";
        }
        while (num > 0)
        {
            divRem = num % d;
            num /= d;
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

            result += remainders[i];
        }
        return result;
    }
    static bool Validation(byte s, byte d)
    {
        if (s < 2 || d < 2 || s > 16 || d > 16)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }
}
