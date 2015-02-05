//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        long decNumber = long.Parse(Console.ReadLine());
        string tempBinNum = "";
        string binaryNumber = "";

        while (decNumber > 0)
        {
            tempBinNum += (decNumber % 2).ToString();
            decNumber /= 2;
        }
        for (int i = tempBinNum.Length - 1; i >= 0; i--)
        {
            binaryNumber += tempBinNum[i].ToString();
        }
        Console.WriteLine("Number's binary representation: " + binaryNumber);
    }
}
