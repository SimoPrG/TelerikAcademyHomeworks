//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinSearch
{
    static void Main()
    {
        Console.Write("Please enter count of array's elements: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}] --> ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());
        int tempK = k;

        Array.Sort(numbers);
       int index = Array.BinarySearch(numbers, k);

       while (Array.BinarySearch(numbers, k) < 0)
       {
           k--;
       }
       Console.WriteLine();
       Console.WriteLine("The largest number in the array less then or equal to {0} is: {1} ",tempK, k);
    }
}

