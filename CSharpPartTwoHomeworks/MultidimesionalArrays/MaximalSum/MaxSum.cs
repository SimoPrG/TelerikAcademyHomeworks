//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Please enter number of rows N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number of colons M: ");
        int m = int.Parse(Console.ReadLine());

        if (n < 3 || m < 3)
        {
            Console.WriteLine("You must enter more than 3 rows and colons!!!");
            return;
        }

        Console.WriteLine("Fill the matrix:");
        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter element [{0}, {1}] -> ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        //int[,] matrix = {
        //                   {2,3,8,100},
        //                   {7,2,4,9},
        //                   {15,4,3,32},
        //                   {200,2,5,10},
        //                   {45,78,10,11}
        //               };
        //int n = matrix.GetLength(0);
        //int m = matrix.GetLength(1);

        PrintMatrix(matrix, n, m);
        FindSum(matrix, matrix.GetLength(0), matrix.GetLength(1));
    }

    static void FindSum(int[,] matrix, int n, int m)
    {
        int tmpSum = int.MinValue;
        int maxSum = 0;
        int startRow = 0;
        int startCol = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                tmpSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (tmpSum >= maxSum)
                {
                    maxSum = tmpSum;
                    startRow = i;
                    startCol = j;
                }
            }
        }
        Console.WriteLine("The square 3 x 3 with max sum is: ");
        PrintSquare(matrix, startRow, startCol);
    }

    static void PrintMatrix(int[,] matrix, int n, int m)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0}\t", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PrintSquare(int[,] matrix, int r, int c)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0}\t", matrix[r + row, c + col]);
            }
            Console.WriteLine();
        }
    }
}

