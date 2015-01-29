//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
using System.Threading;
using System.Globalization;

class SortThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter three numbers: ");
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float thirthNumber = float.Parse(Console.ReadLine());
        Console.Write("The numbers sorted in descending order: ");
        if (firstNumber >= secondNumber)
        {
            if (secondNumber >= thirthNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirthNumber);
            }
            else if (secondNumber <= thirthNumber)
            {
                if (firstNumber <= thirthNumber)
                {
                    Console.WriteLine("{2} {0} {1}", firstNumber, secondNumber, thirthNumber);
                }
                else if (firstNumber >= thirthNumber)
                {
                    Console.WriteLine("{0} {2} {1}", firstNumber, secondNumber, thirthNumber);
                }
            }
        }
        else if (firstNumber <= secondNumber)
        {
            if (secondNumber <= thirthNumber)
            {
                Console.WriteLine("{2} {1} {0}", firstNumber, secondNumber, thirthNumber);
            }
            else if (secondNumber >= thirthNumber)
            {
                if (firstNumber >= thirthNumber)
                {
                    Console.WriteLine("{1} {0} {2}", firstNumber, secondNumber, thirthNumber);
                }

                else if (firstNumber <= thirthNumber)
                {
                    Console.WriteLine("{1} {2} {0}", firstNumber, secondNumber, thirthNumber);
                }
            }
        }
    }
}



