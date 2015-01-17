//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, 
//int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.


using System;
   
class Variables
{
    static void Main()
    {
         ushort varNumOne = 52130;
         sbyte varNumTwo = -115;
         int varNumThree = 4825932;
         byte varNumFour = 97;
         short varNumFive = -10000;
         
        Console.WriteLine("{0} - ushort variable \n{1} - sbyte variable \n{2} - int variable \n{3} - byte variable \n{4} - short variable", 
                           varNumOne, varNumTwo, varNumThree, varNumFour, varNumFive);
    }
}
