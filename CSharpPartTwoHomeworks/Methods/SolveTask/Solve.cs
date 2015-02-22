//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Threading;
using System.Globalization;
using System.Linq;


class Solve
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("\tPlease make your choice!");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine("Press 1 to Reverses the digits of a number.");
        Console.WriteLine("Press 2 to Calculates the average of a sequence of integers.");
        Console.WriteLine("Press 3 to Solves a linear equation a * x + b = 0.");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: ReverseNumber(); break;
            case 2: CalcAvarage(); break;
            case 3: SolveLinearEquation(); break;
            default: Console.WriteLine("Incorrect choice!"); break;
        }
    }

    static void ReverseNumber() //choice 1
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your choice is, to reverse the digits of a number.");
        Console.Write("Please enter number: ");
        decimal num = decimal.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("\nInvalid input!");
            return;
        }
        else
        {
            char[] numArray = num.ToString().ToCharArray();
            Array.Reverse(numArray);
            Console.WriteLine("\nReversed number: " + string.Join("", numArray));
        }
    }

    static void CalcAvarage() //choice 2
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your choice is, to calculate the average of a sequence of integers.");
        Console.WriteLine("Please enter a sequence of integers separated by space:");
        string input = Console.ReadLine();

        if (input.Length <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else
        {
            int[] sequence = input.Split(' ').Select(int.Parse).ToArray();
            double avarage = sequence.Average();
            Console.WriteLine("\nThe avarage of the sequence of integer: {0:F3}", avarage);
        }
    }

    static void SolveLinearEquation() //choice 3
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your choice is, to solve a linear equation a * x + b = 0.");
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("\nInvalid input!");
            return;
        }
        else
        {
            Console.Write("Enter \"b\": ");
            double b = double.Parse(Console.ReadLine());
            double x = (b * -1) / a;
            Console.WriteLine("\n{0} * x + {1} = 0 \nX = {2:F2}", a, b, x);
        }
    }
}

