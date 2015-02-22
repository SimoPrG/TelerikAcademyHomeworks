//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;

class NFactorialApp
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Facturial of number is: " + FindFacturial(ArrayRepresentation(number)));
    }

    static BigInteger FindFacturial(int[] numbers)
    {
        BigInteger facturial = 1;
        for (int i = 0; i < numbers.Length; i++)
			{
                facturial *= numbers[i];
			}
        return facturial;

    }

    static int[] ArrayRepresentation(int number)
    {
        int[] arr = new int[number];
        int index = 1;
        for (int i = 0; i < number; i++)
        {
            arr[i] = index++;
        }
        return arr;
    }
}

