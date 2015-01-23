//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        int numUnsignInt = int.Parse(Console.ReadLine());

        int bitNum = 3;
        int mask = 1 << bitNum;
        int maskAnd = numUnsignInt & mask;
        int bitIs = maskAnd >> bitNum;

        Console.WriteLine("The value of bit number 3 is: " + bitIs);
        Console.WriteLine("Binary representation: \n" + Convert.ToString(numUnsignInt, 2).PadLeft(32, '0'));

    }
}

