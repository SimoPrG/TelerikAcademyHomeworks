//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

//Example:

//  input	    output
//  256	        652
//  123.45	    54.321

using System;
using System.Threading;
using System.Globalization;

class ReverseNum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Result: " + ReverseNumber(number));
    }

    static decimal ReverseNumber(decimal number)
    {
        char[] charArr = number.ToString().ToCharArray();
        Array.Reverse(charArr);

        string tmpStr = new string(charArr);
        decimal reversedNumber = decimal.Parse(tmpStr);
        return reversedNumber;
    }
}


