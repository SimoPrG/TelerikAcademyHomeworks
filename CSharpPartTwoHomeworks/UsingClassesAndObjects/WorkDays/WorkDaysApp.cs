//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class WorkDaysApp
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter a date in format yyyy,MM,dd: ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime nowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        Console.WriteLine("\nFrom {0} to {1}, \nthere are {2} work days. ", nowDate, inputDate, FindWorkDays(inputDate, nowDate));
    }

    static int FindWorkDays(DateTime inDate, DateTime nowDate)
    {
        int count = 0;
        while (inDate != nowDate)
        {

            nowDate = nowDate.AddDays(1);
            if (nowDate.DayOfWeek != DayOfWeek.Saturday && nowDate.DayOfWeek != DayOfWeek.Sunday && !IsHoliday(nowDate))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsHoliday(DateTime date)
    {
        DateTime[] holidays = {
                                  new DateTime (date.Year, 01, 01),
                                  new DateTime (date.Year, 03, 03),
                                  new DateTime (date.Year, 05, 06),
                                  new DateTime (date.Year, 05, 24),
                                  new DateTime (date.Year, 09, 06),
                                  new DateTime (date.Year, 09, 22),
                                  new DateTime (date.Year, 12, 25),
                                  new DateTime (date.Year, 12, 26)
                              };
        return holidays.Contains(date.Date);
    }
}

