//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Threading;
using System.Globalization;

class DateDifferenceApp
{
    static void Main()
    {
        CultureInfo cult = CultureInfo.InvariantCulture;
        string dateFormat = "d.M.yyyy";

        Console.Write("Please enter first date: ");
        var dateOne = DateTime.ParseExact(Console.ReadLine(), dateFormat, cult);
        Console.Write("Please enter second date: ");
        var dateTwo = DateTime.ParseExact(Console.ReadLine(), dateFormat, cult);

        Console.WriteLine("\nDistance: {0} days.", Math.Abs((dateTwo - dateOne).TotalDays));
    }
}

