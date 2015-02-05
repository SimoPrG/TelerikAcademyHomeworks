//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Threading;
using System.Globalization;

class CalculateExp
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter two numbers n and x:");
        Console.Write("n = ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int numX = int.Parse(Console.ReadLine());
        float sum = 1;
        float facturial = 1;
        float power = 1;
        for (int i = 1; i <= numN; i++)
        {
            facturial *= i;
            power *= numX;
            sum += (float)facturial / (float)power;
        }
        Console.WriteLine("The sum is: {0:F5}", sum);
    }
}