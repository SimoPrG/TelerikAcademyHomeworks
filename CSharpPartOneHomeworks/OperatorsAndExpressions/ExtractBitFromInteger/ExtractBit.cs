//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        int numUnsignInt = int.Parse(Console.ReadLine());

        Console.Write("Enter position of bit: ");
        int bitPosition = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;
        int maskAnd = numUnsignInt & mask;
        int bitIs = maskAnd >> bitPosition;

        Console.WriteLine("The value of bit with position {0} is: {1}", bitPosition, bitIs);
        Console.WriteLine("Binary representation: \n" + Convert.ToString(numUnsignInt, 2).PadLeft(32, '0'));
    }
}

