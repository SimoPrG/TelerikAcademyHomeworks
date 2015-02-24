//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RndNums
{
    static void Main()
    {
        Random rndGenerator = new Random();
        int count = 10;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(rndGenerator.Next(100, 200));
        }
    }
}

