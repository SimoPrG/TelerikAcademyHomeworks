using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.RefactorTheFollowingLoop
{
    class Refactorloop
    {
        static void PrintNumbers(int expectedNumber)
        {
            int[] numbers = new int[100];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0 && numbers[i] == expectedNumber)
                {
                    Console.WriteLine("Value Found");
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
