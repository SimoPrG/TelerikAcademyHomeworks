//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

//Examples:

// input   | output
//  512	   |  two
//  1024   |  four
//  12309  |  nine

using System;

class EngDigit
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The last digit is {0}.", LastDigitAsWord(number));
    }

    static string LastDigitAsWord(int num)
    {
        int digit = num % 10;
        string digAsWord = "";

        switch (digit)
        {
            case 0: digAsWord = "zero"; break;
            case 1: digAsWord = "one"; break;
            case 2: digAsWord = "two"; break;
            case 3: digAsWord = "three"; break;
            case 4: digAsWord = "four"; break;
            case 5: digAsWord = "five"; break;
            case 6: digAsWord = "six"; break;
            case 7: digAsWord = "seven"; break;
            case 8: digAsWord = "eight"; break;
            case 9: digAsWord = "nine"; break;
            default: break;
        }
        return digAsWord;
    }
}

