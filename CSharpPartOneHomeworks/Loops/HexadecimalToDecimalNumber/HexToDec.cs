//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        long decNum = 0;
        for (int i = 0; i < hexNum.Length; i++)
        {
            int tempVar = 0;
            switch (hexNum[i])
            {
                case 'A': tempVar = 10;
                    break;
                case 'B': tempVar = 11;
                    break;
                case 'C': tempVar = 12;
                    break;
                case 'D': tempVar = 13;
                    break;
                case 'E': tempVar = 14;
                    break;
                case 'F': tempVar = 15;
                    break;
                default: tempVar = int.Parse(hexNum[i].ToString());
                    break;
            }
            decNum += tempVar * (long)Math.Pow(16, (hexNum.Length - 1) - i);
        }
        Console.WriteLine("Decimal form of the number: " + decNum);
    }
}

