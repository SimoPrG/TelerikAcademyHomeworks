//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binNum = Console.ReadLine();
        long decNum = 0;
        for (int i = 0; i < binNum.Length ; i++)
        {
            decNum += int.Parse(binNum[i].ToString()) * (long)Math.Pow(2, (binNum.Length -1) - i);
        }
        Console.WriteLine("Decimal form of the number: " + decNum);
    }
}
