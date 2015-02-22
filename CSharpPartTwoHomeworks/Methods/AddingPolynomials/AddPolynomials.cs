//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

//Example:

//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;
using System.Threading;
using System.Globalization;

public class AddPolynomials
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal[] polyOne = { 3, 2.5M, -7, 1.35M, 4 };
        decimal[] polyTwo = { 12, 3, 4.5M, 0, 8, -15, 18 };
        Console.Write("First polinimial: ");
        PrintPolynomial(polyOne);
        Console.Write("Second polinimial: ");
        PrintPolynomial(polyTwo);
        Console.Write("\nSum of polinomials is: ");
        PrintPolynomial(AddingPolynomial(polyOne, polyTwo));

    }
    static void PrintPolynomial(decimal[] poly)
    {
        Console.WriteLine(string.Join(", ", poly));
    }

    public static decimal[] AddingPolynomial(decimal[] polyOne, decimal[] polyTwo)
    {
        int tmpLength = Math.Min(polyOne.Length, polyTwo.Length);
        decimal[] sumPoly = new decimal[Math.Max(polyOne.Length, polyTwo.Length)];
        Array.Reverse(polyOne);
        Array.Reverse(polyTwo);

        for (int i = 0; i < tmpLength; i++)
        {
            sumPoly[i] = polyOne[i] + polyTwo[i];
        }

        for (int i = tmpLength; i < sumPoly.Length; i++)
        {
            if (polyOne.Length > polyTwo.Length)
            {
                sumPoly[i] = polyOne[i];
            }
            else
            {
                sumPoly[i] = polyTwo[i];
            }
        }

        Array.Reverse(sumPoly);
        return sumPoly;
    }
}

