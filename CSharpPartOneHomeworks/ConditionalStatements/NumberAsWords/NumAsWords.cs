//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
class NumAsWords
{
    static void Main()
    {
        Console.Write("Please enter a number in the range [0...999]: ");
        int numbers = int.Parse(Console.ReadLine());

        int units = numbers % 10;
        int tenths = (numbers / 10) % 10;
        int hundreds = numbers / 100;

        string[] unitsWordsUpperCase = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
         "Eleven", "Tvelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] unitsWords = {"null", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
         "eleven", "tvelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] tenthsWords = { "null", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] tenthsWordsUpperCase = { "null", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] hundredsWords = {"null", "Hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred",
                                     "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred"};
        Console.Write("Number as words: ");

        if (numbers < 20)
        {
            Console.WriteLine(unitsWordsUpperCase[numbers]);
        }
        else if (numbers < 100)
        {
            Console.WriteLine(tenthsWordsUpperCase[tenths] + " " + unitsWords[units]);
        }
        else if (numbers < 1000)
        {
            if (tenths == 0 && units == 0)
            {
                Console.WriteLine(hundredsWords[hundreds]);
            }
            else if (tenths == 0 && units != 0)
            {
                Console.WriteLine(hundredsWords[hundreds] + " and " + unitsWords[units]);
            }
            else if (tenths == 1)
            {
                Console.WriteLine(hundredsWords[hundreds] + " and " + unitsWords[numbers % 100]);
            }
            else
            {
                Console.WriteLine(hundredsWords[hundreds] + " and " + tenthsWords[tenths] + " " + unitsWords[units]);
            }
        }

    }
}
