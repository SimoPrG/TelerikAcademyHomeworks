//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyABit
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        int numUnsignInt = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation: " + Convert.ToString(numUnsignInt, 2).PadLeft(32, '0'));

        Console.Write("Enter position of bit: ");
        int bitNum = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit value (0 or 1); ");
        byte bitVal = byte.Parse(Console.ReadLine());
        int mask = 1 << bitNum;
        if (bitVal == 0)
        {
            int result = numUnsignInt & ~(mask);
            Console.WriteLine("Result in integer: " + result);
            Console.WriteLine("Result in binary representation: " + Convert.ToString(result, 2).PadLeft(32, '0'));
        }
        else
        {
            int result = numUnsignInt | mask;
            Console.WriteLine("Result in integer: " + result);
            Console.WriteLine("Result in binary representation: " + Convert.ToString(result, 2).PadLeft(32, '0'));
        }
    }
}

