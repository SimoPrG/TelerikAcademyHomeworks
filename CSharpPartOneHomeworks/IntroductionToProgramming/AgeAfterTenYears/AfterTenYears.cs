//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthday date in format dd/MM/yyyy:");
        DateTime birthdayDate = DateTime.Parse(Console.ReadLine());
        DateTime nowDate = DateTime.Now;
        int nowAge = nowDate.Year - birthdayDate.Year;
        if (nowDate.DayOfYear < birthdayDate.DayOfYear)
        {
            nowAge = nowAge - 1;
        }
        Console.WriteLine("Now you are {0} years old.", nowAge);
        Console.WriteLine("After ten years you will be {0} years old.", nowAge + 10);

    }
}
