//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;

class CompCharArrays
{
    static void Main()
    {
        char[] charArrayOne = Console.ReadLine().ToCharArray();
        char[] charArrayTwo = Console.ReadLine().ToCharArray();
        int length = 0;

        if (charArrayOne.Length == charArrayTwo.Length)
        {
            length = charArrayOne.Length;
        }
        else
        {
            Console.WriteLine("The lengths of the arrays are not equal!");
            length = Math.Min(charArrayOne.Length, charArrayTwo.Length);
        }

        for (int i = 0; i < length; i++)
        {
            if (charArrayOne[i] == charArrayTwo[i])
            {
                Console.WriteLine("{0} - {1}: The elements of two arrays are equal!", charArrayOne[i], charArrayTwo[i]);
            }
            else if (charArrayOne[i] < charArrayTwo[i])
            {
                Console.WriteLine("{0} - {1}: The first element is before the second one!", charArrayOne[i], charArrayTwo[i]);
            }
            else if (charArrayOne[i] > charArrayTwo[i])
            {
                Console.WriteLine("{0} - {1}: The first element is after the second one!", charArrayOne[i], charArrayTwo[i]);
            }
        }
    }
}

