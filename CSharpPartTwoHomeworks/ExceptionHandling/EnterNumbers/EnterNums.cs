//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class Program
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int countOfNums = 10;
        int lastNum = 1;

        try
        {
            Console.WriteLine("Please enter 10 number in range [2..99], such that 1 < a1 < ... < a10 < 100:");
            for (int i = 0; i < countOfNums; i++)
            {
                Console.Write("Enter a{0}: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                ReadNumber(start, end, number, lastNum);
                lastNum = number;
            }

        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("\nNumber is out of range!");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nInvalid number!");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("\nEach entered number must be greater than previous!");
        }
    }

    static void ReadNumber(int start, int end, int num, int lastNum)
    {
        if (num < start || num > end)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (num <= lastNum)
        {
            throw new InvalidOperationException();
        }
    }
}
