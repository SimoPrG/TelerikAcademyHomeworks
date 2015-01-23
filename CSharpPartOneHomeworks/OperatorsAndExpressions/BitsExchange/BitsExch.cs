//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExch
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        for (int i = 3; i < 6; i++)
        {
            uint mask = (uint)(1 << i);
            uint operateBitOne = (number & mask) >> i;

            mask = (uint)(1 << (21 + i));
            uint operateBitTwo = (number & mask) >> (21 + i);
            
            if (operateBitOne == 1)
            {
                mask = (uint)(1 << (21 + i));
                number = number | mask;
            }
            else if (operateBitOne == 0)
            {
                mask = (uint)(~(1 << (21 + i)));
                number = number & mask;
            }
            if (operateBitTwo == 1)
            {
                mask = (uint)(1 << i);
                number = number | mask;
            }
            else if (operateBitTwo == 0)
            {
                mask = (uint)(~(1 << i));
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









