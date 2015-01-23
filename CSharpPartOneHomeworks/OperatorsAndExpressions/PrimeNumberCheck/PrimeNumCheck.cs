//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumCheck
{
    static void Main()
    {
        Console.Write("Enter a integer number: ");
        int num = int.Parse(Console.ReadLine());
        if (num < 0 || num > 100)
        {
            Console.WriteLine("Enter a positive and less than or equal to 100 integer number !");
            return;
        }
        bool check = false;
        for (int i = 2; i < num / 2; i++)
        {
            if (i == num)
                i = i + 1;
            if (num % i == 0)
            {
                check = true;
                break;
            }
        }
        if (check == false && num != 1)
        {
            Console.WriteLine("The number is prime.");
        }
        else 
        {
            Console.WriteLine("The number is not prime.");
        }
    }
}

