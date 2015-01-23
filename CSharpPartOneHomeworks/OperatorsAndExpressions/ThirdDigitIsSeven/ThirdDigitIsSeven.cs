//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool check = (number / 100) % 10 == 7;
        Console.WriteLine("Third digit from right-to-left is 7? " + check);
    }
}

