//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Text;

class CorrectBracketsApp
{
    static void Main()
    {
        Console.Write("Please enter expression: ");
        string input = Console.ReadLine();

        Console.WriteLine("\nThe breackets are {0}.", AreBreacketsPutCorrectly(input) ? "put correctly" : "not put correctly");
    }

    private static bool AreBreacketsPutCorrectly(string exp)
    {
        int count = 0;

        foreach (var item in exp)
        {
            if (item == '(')
            {
                count++;
            }
            else if (item == ')')
            {
                count--;
            }

            if (count < 0)
            {
                return false;
            }
        }
        return count == 0;
    }
}
