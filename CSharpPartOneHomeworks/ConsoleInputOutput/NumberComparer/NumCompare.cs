//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Threading;
using System.Globalization;

class NumCompare
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter two numbers.");
        Console.Write("Enter first one: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.Write("Enter second one: ");
        float numberTwo = float.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is : {0}", numberOne > numberTwo ? numberOne : numberTwo);
    }
}
