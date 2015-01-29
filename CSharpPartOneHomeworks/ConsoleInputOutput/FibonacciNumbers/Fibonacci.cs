//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Please enter number \"n\": ");
        int n = int.Parse(Console.ReadLine());
        int firstMem = 0;
        int secondMem = 1;
        int newMem = 0;
        Console.WriteLine("The first {0} members of the Fibonacci sequence:", n);
        if (n == 1)
        {
            Console.WriteLine("{0}.", firstMem);
            return;
        }
        else if (n == 2)
        {
            Console.WriteLine("{0}, {1}.", firstMem, secondMem);
            return;
        }
        Console.Write("{0}, {1}", firstMem, secondMem);
        for (int i = 2; i < n; i++)
        {
            newMem = firstMem + secondMem;
            firstMem = secondMem;
            secondMem = newMem;
            Console.Write(", {0}", newMem);
        }
        Console.Write(".");
        Console.WriteLine();
    }
}

