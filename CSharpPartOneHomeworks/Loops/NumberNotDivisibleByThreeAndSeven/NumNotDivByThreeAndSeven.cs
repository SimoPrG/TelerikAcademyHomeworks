//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n 
//not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NumNotDivByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;

        while (counter <= number)
        {
            if (counter % 3 != 0 && counter % 7 != 0)
            {
                Console.Write(counter + " ");
            }
            counter++;
        }
        Console.WriteLine();
    }
}

