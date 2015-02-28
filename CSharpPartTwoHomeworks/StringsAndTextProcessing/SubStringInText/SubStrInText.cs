//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;
using System.Text;

class SubStrInText
{
    static void Main()
    {
        string inputStr = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string inputSubStr = "in";

        Console.WriteLine("Result is: {0}", HowManyTimes(inputStr, inputSubStr));
    }

    private static int HowManyTimes(string inputStr, string inputSubStr)
    {
        inputStr = inputStr.ToLower();

        int count = 0;
        int index = inputStr.IndexOf("in");

        while (index != -1)
        {
            count++;
            index = inputStr.IndexOf("in", index + 1);
        }

        return count;
    }
}

