//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	                output
//4     
//2 3 3 4 
//0 2 3 4               17
//3 7 1 2 
//4 3 3 2	            

using System;
using System.IO;
using System.Linq;

class MaxAreaSum
{
    static void Main()
    {
        try
        {
            var reader = new StreamReader(@"..\..\input.txt");
            var result = new StreamWriter(@"..\..\output.txt");
            int n = 0;

            using (reader)
            {
                n = int.Parse(reader.ReadLine());
                string currLine = reader.ReadLine();
                int[,] matrix = new int[n, n];
                int row = 0;

                while (currLine != null)
                {
                    int[] arr = currLine.Split(' ').Select(int.Parse).ToArray();

                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = arr[col];
                    }
                    currLine = reader.ReadLine();
                    row++;
                }
                using (result)
                {
                    result.WriteLine(FindMaxSum(matrix));
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static int FindMaxSum(int[,] matrix)
    {
        int maxSum = 0;
        int currSum = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currSum >= maxSum)
                {
                    maxSum = currSum;
                }
            }
        }
        return maxSum;
    }
}

