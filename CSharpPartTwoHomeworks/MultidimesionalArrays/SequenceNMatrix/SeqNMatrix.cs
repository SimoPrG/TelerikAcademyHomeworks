//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements
//located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SeqNMatrix
{
    static void Main()
    {
        Console.Write("Please enter number of rows N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number of colons M: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("[{0}, {1}] - ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        //string[,] matrix = {
        //                       {"s","qq","s"},
        //                       {"pp","pp","s"},
        //                       {"pp","qq","s"}
        //                   };
        //int n = matrix.GetLength(0);
        //int m = matrix.GetLength(1);

        PrintMatrix(matrix, n, m);
        FindEqualStrings(matrix, n, m);

    }
    
    static void FindEqualStrings(string[,] matrix, int n, int m)
    {
        int currentCount = 1;
        int count = 1;
        string tmpStr = "";


        //horizontal check
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col + 1] == matrix[row, col])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount >= count)
                {
                    count = currentCount;
                    tmpStr = matrix[row, col];
                }
            }
            currentCount = 1;
        }

        //vertical check
        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row + 1, col] == matrix[row, col])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount >= count)
                {
                    count = currentCount;
                    tmpStr = matrix[row, col];
                }
            }
            currentCount = 1;
        }

        //diagonal check
        for (int i = 0; i <= m - n; i++)
        {
            for (int row = 0, col = 0 + i; row < n - 1 && col < m - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (count <= currentCount)
                {
                    count = currentCount;
                    tmpStr = matrix[row, col];
                }
            }
            currentCount = 1;
        }
        for (int i = m - n; i >= 0; i--)
        {
            for (int row = 0, col = m - 1 - i; row < n - 1 && col > 0; row++, col--)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (count <= currentCount)
                {
                    count = currentCount;
                    tmpStr = matrix[row, col];
                }
            }
            currentCount = 1;
        }
        PrintSequence(tmpStr, count);
    }
    static void PrintSequence(string tmpStr, int count)
    {
        Console.WriteLine();
        Console.Write("The longest sequence of equal strings is: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write("{0}, ", tmpStr);
        }
        Console.WriteLine("\b\b ");
    }
    static void PrintMatrix(string[,] matrix, int n, int m)
    {
        Console.WriteLine();
        Console.WriteLine("Your matrix is: ");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0}\t", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

