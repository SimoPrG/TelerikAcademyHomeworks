//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? varNumOne = null;
        double? varNumTwo = null;
        Console.WriteLine("This is the integer variable with null value: \" {0} \"", varNumOne);
        Console.WriteLine("This is the double variable with null value:  \" {0} \"", varNumTwo);
        varNumOne = 13;
        varNumTwo = 17.31;
        Console.WriteLine("This is the integer variable with value 13:  \"{0}\"", varNumOne);
        Console.WriteLine("This is the double variable with value 17.31:\"{0}\"", varNumTwo);
    }
}
