//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.

using System;

class BeerTimeApp
{
    static void Main()
    {
        Console.Write("Enter time in format \"hh:mm tt\": ");
        try
        {
            DateTime timeValue = DateTime.Parse(Console.ReadLine());
            bool isPM = timeValue.Hour >= 12;
            if (isPM)
            {
                Console.WriteLine("Beer time!");
                return;
            }
            else
            {
                switch (timeValue.Hour)
                {
                    case 1:
                    case 2: Console.WriteLine("Beer time!");
                        break;
                    default: Console.WriteLine("Non-beer time!");
                        break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Inavalid time!");
        }
    }
}
