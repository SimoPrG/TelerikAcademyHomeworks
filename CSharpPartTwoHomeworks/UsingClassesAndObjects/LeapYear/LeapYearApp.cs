//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYearApp
{
    static void Main()
    {
        Console.Write("Please enter a year: ");
        int inputYear = int.Parse(Console.ReadLine());
        Console.WriteLine("\nIs leap year? {0}", DateTime.IsLeapYear(inputYear) ? "Yes":"No");
    }
}

