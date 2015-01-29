//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Threading;
using System.Globalization;


class FormattingNum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter three numbers!");
        Console.Write("Enter first number (integer): ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter second number (floating-point): ");
        float numberTwo = float.Parse(Console.ReadLine());
        Console.Write("Enter third number (floating-point): ");
        float numberThree = float.Parse(Console.ReadLine());
        if (numberOne < 0 || numberOne > 500)
        {
            Console.WriteLine("First number must be greater or equal than 0 and less or equal than 500!!!");
            return;
        }
        string numOneBin = Convert.ToString(numberOne, 2).PadLeft(10, '0');
        Console.WriteLine();
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", numberOne, numOneBin, numberTwo, numberThree);
    }
}

