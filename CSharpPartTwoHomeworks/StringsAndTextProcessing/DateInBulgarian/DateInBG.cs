//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class DateInBG
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string dateForamat = "d.M.yyyy HH:mm:ss";
        Console.WriteLine("Enter a date in format: day.month.year hour:minute:second");
        var date = DateTime.ParseExact(Console.ReadLine(), dateForamat, CultureInfo.InvariantCulture).AddHours(6).AddMinutes(30);
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        

        Console.WriteLine("\nDate after 6 hours and 30 minutes: {0} - {1}", date, date.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
