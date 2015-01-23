//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNum
{
    static void Main()
    {
        Console.Write("Enter four-digit number in format abcd (e. g. 2011): ");
        int fourDigitNum = int.Parse(Console.ReadLine());
        string number = fourDigitNum.ToString();
        if (number.Length != 4 || number[0] == 0) 
        {
            Console.WriteLine("You must enter four-digit number and the first digit can't be 0!!!");
            return;
        }
        
        int d = fourDigitNum % 10;
        int c = (fourDigitNum / 10) % 10;
        int b = (fourDigitNum / 100) % 10;
        int a = (fourDigitNum / 1000) % 10;
        
        int sum = (a + b + c + d);

        Console.WriteLine("The sum of the digits is: " + sum);
        Console.WriteLine("Number in reversed order: {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last digit in the first position: {3}{0}{1}{2}", a, b , c, d);
        Console.WriteLine("Exchange the second and the third digit: {0}{2}{1}{3}", a, b, c, d);
    }
}

