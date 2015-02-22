//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Threading;
using System.Globalization;

class SubPolynomials
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal[] polyOne = { 3, 2.5M, -7 };
        decimal[] polyTwo = { 12, 3, 4.5M, 1 };
        Console.Write("First polinimial: ");
        PrintPolynomial(polyOne);
        Console.Write("Second polinimial: ");
        PrintPolynomial(polyTwo);
        Console.Write("\nSum of polinomials is: ");
        PrintPolynomial(AddPolynomials.AddingPolynomial(polyOne, polyTwo)); //uses a method from previous problem
        Console.Write("Subtraction of polinomials is: ");
        PrintPolynomial(SubtractionPolynomial(polyOne, polyTwo));
        Console.Write("Multiplication of polinomials is: ");
        PrintPolynomial(MultiplicationPolinomials(polyOne, polyTwo));

    }
    static void PrintPolynomial(decimal[] poly)
    {
        Console.WriteLine(string.Join(", ", poly));
    }

    static decimal[] SubtractionPolynomial(decimal[] polyOne, decimal[] polyTwo)
    {
        int tmpLength = Math.Min(polyOne.Length, polyTwo.Length);
        decimal[] subPoly = new decimal[Math.Max(polyOne.Length, polyTwo.Length)];
       
        for (int i = 0; i < tmpLength; i++)
        {
            subPoly[i] = polyOne[i] - polyTwo[i];
        }

        for (int i = tmpLength; i < subPoly.Length; i++)
        {
            if (polyOne.Length > polyTwo.Length)
            {
                subPoly[i] = polyOne[i];
            }
            else
            {
                subPoly[i] = polyTwo[i];
            }
        }

        Array.Reverse(subPoly);
        return subPoly;
    }

    static decimal[] MultiplicationPolinomials(decimal[] polyOne, decimal[] polyTwo)
    {
        decimal[] mulPoly = new decimal[(polyOne.Length + polyTwo.Length) - 1];

        for (int i = 0; i < polyOne.Length; i++)
        {
            for (int j = 0; j < polyTwo.Length; j++)
            {
                mulPoly[i + j] += polyOne[i] * polyTwo[j];
            }  
        }

        Array.Reverse(mulPoly);
        return mulPoly;
    }
}

