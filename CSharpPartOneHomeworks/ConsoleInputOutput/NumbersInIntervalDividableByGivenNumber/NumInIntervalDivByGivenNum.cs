//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0.

using System;

class NumInIntervalDivByGivenNum
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers.");
        int counter = 0;
        Console.Write("Enter your first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        if (firstNum < 0 || secondNum < 0 || firstNum >= secondNum)
        {
            Console.WriteLine("Please enter a correct values!!!");
            return;
        }
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0}, ", i);
                counter++;
            }
        }
        Console.WriteLine("\b\b ");
        Console.WriteLine("{0} numbers exist in interval ({1} to {2}), division by 5 with reminder 0.", counter, firstNum, secondNum);
    }
}
