//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdv
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        long number = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter position of first bit: ");
        int positionBitP = int.Parse(Console.ReadLine());
        Console.Write("Enter position of second bit: ");
        int positionBitQ = int.Parse(Console.ReadLine());
        Console.Write("Enter count of bits to exchange: ");
        int countBitExch = int.Parse(Console.ReadLine());
        if (Math.Abs(positionBitP - positionBitQ) < countBitExch & positionBitP >= 0 & positionBitQ >= 0)
        {
            Console.WriteLine("Bits overlapping!");
            return;
        }
        else if (positionBitP < 0 ||
                 positionBitQ < 0 ||
                 positionBitP + countBitExch > 32 ||
                 positionBitQ + countBitExch > 32 ||
                 number > uint.MaxValue)
        {
            Console.WriteLine("Out of range!");
            return;
        }
        for (int i = 0; i < countBitExch; i++)
        {
            uint mask = (uint)(1 << (positionBitP + i));
            long operateBitOne = (number & mask) >> (positionBitP + i);

            mask = (uint)(1 << (positionBitQ + i));
            long operateBitTwo = (number & mask) >> (positionBitQ + i);
            if (operateBitOne == 1)
            {
                mask = (uint)(1 << (positionBitQ + i));
                number = number | mask;
            }
            else if (operateBitOne == 0)
            {
                mask = (uint)(~(1 << (positionBitQ + i)));
                number = number & mask;
            }
            if (operateBitTwo == 1)
            {
                mask = (uint)(1 << (positionBitP + i));
                number = number | mask;
            }
            else if (operateBitTwo == 0)
            {
                mask = (uint)(~(1 << (positionBitP + i)));
                number = number & mask;
            }
            else
            {
                Console.WriteLine("The program doesn't work properly!!!");
            }
        }
        Console.WriteLine("Your new number is: {0}", number);
        Console.WriteLine("Your new number in binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}



