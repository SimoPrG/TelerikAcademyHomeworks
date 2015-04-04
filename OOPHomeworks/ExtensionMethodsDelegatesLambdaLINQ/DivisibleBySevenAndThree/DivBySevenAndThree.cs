//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    class DivBySevenAndThree
    {
        static void Main()
        {
            var numbers = new int[] { 5, 25, 21, 252, 42, 457, 98, 126 };

            //using extension methods
            var numsDivBySevenAndThree = numbers.Where(n => n % 21 == 0);

            Console.WriteLine("Using extension methods.");
            Console.WriteLine(string.Join(", ", numsDivBySevenAndThree));

            //using LINQ query
            var numsDivBySevenAndThreeLinq =
                from num in numbers
                where num % 21 == 0
                select num;

            Console.WriteLine("\nUsing linq query.");
            Console.WriteLine(string.Join(", ", numsDivBySevenAndThreeLinq));
        }
    }
}
