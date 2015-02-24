//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;

class DayOfWeekApp
{
    static void Main()
    {
        DateTime dayOfWeek = new DateTime();
        Console.WriteLine("Today is: " + dayOfWeek.DayOfWeek);
    } 
}

