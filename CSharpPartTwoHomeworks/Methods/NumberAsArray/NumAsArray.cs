//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;

class NumAsArray
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        string numberOne = Console.ReadLine();
        Console.Write("Please enter the second number: ");
        string numberTwo = Console.ReadLine();
        ArrayRepresentation(numberOne, numberTwo);
    }

    static void ArrayRepresentation(string numOne, string numTwo)
    {
        int[] arrOne = new int[numOne.Length];
        int[] arrTwo = new int[numTwo.Length];
        bool tmp = false;
        for (int i = 0; i < numOne.Length; i++)
        {
            arrOne[numOne.Length - 1 - i] = numOne[i] - '0';
        }
        for (int i = 0; i < numTwo.Length; i++)
        {
            arrTwo[numTwo.Length - 1 - i] = numTwo[i] - '0';
        }
        if (arrOne.Length == arrTwo.Length && arrOne[arrOne.Length - 1] + arrTwo[arrTwo.Length - 1] > 9)
        {
            tmp = true;
        }
       
        Console.WriteLine("The sum is: {0}{1}", tmp? "1":"", string.Join("", FindSum(arrOne, arrTwo)));
    }

    static int[] FindSum(int[] numOne, int[] numTwo)
    {
        int length = Math.Max(numOne.Length, numTwo.Length);
        int[] sum = new int[length];
        int remainder = 0;

        for (int i = 0; i < Math.Min(numOne.Length, numTwo.Length); i++)
        {
            sum[i] = numOne[i] + numTwo[i] + remainder;
            if (remainder == 1)
            {
                remainder = 0;  
            }
            if (sum[i] > 9)
            {
                sum[i] = sum[i] % 10;
                remainder = 1;
            }
        }
        if (numOne.Length > numTwo.Length)
        {
            for (int i = numTwo.Length; i < numOne.Length; i++)
            {
                sum[i] = numOne[i] + remainder;
                if (remainder == 1)
                {
                    remainder = 0;
                }
            }
        }
        else if (numOne.Length < numTwo.Length)
        {
            for (int i = numOne.Length; i < numTwo.Length; i++)
            {
                sum[i] = numTwo[i] + remainder;
                if (remainder == 1)
                {
                    remainder = 0;
                }
            }
        }
       
        Array.Reverse(sum);
        return sum;
    }
}



