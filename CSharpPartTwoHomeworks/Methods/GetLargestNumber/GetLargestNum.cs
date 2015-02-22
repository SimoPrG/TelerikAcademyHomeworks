//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int larger = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
        Console.WriteLine("The larger number is: " + larger);

    }

    static int GetMax(int firstNum, int secondNum)
    {
        int maxNum = 0;
        if (firstNum > secondNum)
        {
            maxNum = firstNum;
        }
        else
        {
            maxNum = secondNum;
        }
        return maxNum;
    }
}

