//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;

class CheckABit
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        int numUnsignInt = int.Parse(Console.ReadLine());

        Console.Write("Enter position of bit: ");
        int bitNum = int.Parse(Console.ReadLine());

        int mask = 1 << bitNum;
        int maskAnd = numUnsignInt & mask;
        int bitIs = maskAnd >> bitNum;
        bool check = (bitIs == 1);

        Console.WriteLine("The value of bit at psition {0} is 1? --> {1}", bitNum, check);
        Console.WriteLine("Binary representation: \n" + Convert.ToString(numUnsignInt, 2).PadLeft(32, '0'));
    }
}

