//Problem 2. Float or Double?
//
//Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatDouble
{
    static void Main()
    {
        double varNumOne = 34.567839023;
        float varNumTwo = 12.345F;
        double varNumThree = 8923.1234857;
        float varNumFour = 3456.091F;

        Console.WriteLine("Type Float: " + varNumTwo +"; " + varNumFour + "\nType Double: " + varNumOne + "; "+ varNumThree);
    }
}

