//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        long decNumber = long.Parse(Console.ReadLine());
        long divRem = 0;
        string tempVar = "";
        string hexadecimalNumber = "";
        string reverseHexNum = ""; 

        while (decNumber > 0)
        {
            divRem += decNumber % 16;
            decNumber /= 16;

            switch (divRem)
            {
                case 0: tempVar = "0";
                    break;
                case 1: tempVar = "1";
                    break;
                case 2: tempVar = "2";
                    break;
                case 3: tempVar = "3";
                    break;
                case 4: tempVar = "4";
                    break;
                case 5: tempVar = "5";
                    break;
                case 6: tempVar = "6";
                    break;
                case 7: tempVar = "7";
                    break;
                case 8: tempVar = "8";
                    break;
                case 9: tempVar = "9";
                    break;
                case 10: tempVar = "A";
                    break;
                case 11: tempVar = "B";
                    break;
                case 12: tempVar = "C";
                    break;
                case 13: tempVar = "D";
                    break;
                case 14: tempVar = "E";
                    break;
                case 15: tempVar = "F";
                    break;
                default:
                    break;
            }
            hexadecimalNumber += tempVar;
            divRem = 0;
        }
        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
           reverseHexNum += hexadecimalNumber[i].ToString();
        }
        Console.WriteLine("Number's hexadecimal representation: " + reverseHexNum);
    }
}
