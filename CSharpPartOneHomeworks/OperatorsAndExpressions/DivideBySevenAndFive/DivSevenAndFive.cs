//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivSevenAndFive
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        bool isItDiv = num / 35 != 0 && num % 35 == 0;
        Console.WriteLine("The number can be divided by 7 and 5? " + isItDiv);
    }
}

