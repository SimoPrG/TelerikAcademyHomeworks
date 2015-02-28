//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesInCanada
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine(); 

        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(new CultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
    }
}

