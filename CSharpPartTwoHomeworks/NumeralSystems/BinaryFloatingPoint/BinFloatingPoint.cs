//Problem 9.* Binary floating-point

//Write a program that shows the internal binary representation of given 32-bit signed floating-point number 
//in IEEE 754 format (the C# type float).

//Example:

//      number	    sign	    exponent	        mantissa
//      -27,25	     1	        10000011	 10110100000000000000000

using System;
using System.Threading;
using System.Globalization;

class BinFloatingPoint
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter 32-bit signed floating-point number: ");
        float number = float.Parse(Console.ReadLine());

        string getBinaryFin = GetBinary(number);

        Console.WriteLine("\nNumber: {0} Sign: {1} Exponent: {2} Mantissa: {3} ", getBinaryFin[0], getBinaryFin.Substring(1, 8), getBinaryFin.Substring(9, 22));
    }

    static string GetBinary(float num)
    {
        byte[] numArr = BitConverter.GetBytes(num);
        string ab = "";
        for (int i = 0; i < numArr.Length; i++) 
        {
            ab = Convert.ToString(numArr[i], 2).PadLeft(8, '0') + ab;
        }
        return ab;
    }
}

