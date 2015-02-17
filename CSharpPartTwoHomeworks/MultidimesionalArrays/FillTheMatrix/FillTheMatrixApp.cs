/*Problem 1. Fill the matrix

 Write a program that fills and prints a matrix of size (n, n) as shown below:

 Example for n=4:
 
      a)	                  b)	                  c)	                  d)*
1	5	9	13          1	8	9	16          7	11	14	16          1	12	11	10
2	6	10	14          2	7	10	15          4	8	12	15          2	13	16	9
3	7	11	15          3	6	11	14          2	5	9	13          3	14	15	8
4	8	12	16          4	5	12	13          1	3	6	10          4	5	6	7
  
*/

using System;

class FillTheMatrixApp
{
    static void Main()
    {
        Console.Write("Enter the size of matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please make your choice a, b, or c: ");
        char choice = char.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        switch (choice)
        {
            case 'a': FillMatrixA(matrix, n); break;
            case 'b': FillMatrixB(matrix, n); break;
            case 'c': FillMatrixC(matrix, n); break;

            default: Console.WriteLine("Please make a correct choice!"); break;
        }

    }

    //Implement case A.
    static void FillMatrixA(int[,] matrix, int n)
    {
        int elementVal = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = elementVal++;
            }
        }
        PrintMatrix(matrix);
    }

    //Implement case B.
    static void FillMatrixB(int[,] matrix, int n)
    {
        int elementVal = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = elementVal++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = elementVal++;
                }
            }
        }
        PrintMatrix(matrix);
    }

    //Implement case C.
    static void FillMatrixC(int[,] matrix, int n)
    {
        int elementVal = 1;
        int currCol = 0;
        int currRow = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            currRow = i;
            currCol = 0;

            while (currRow < n && currRow < n)
            {
                matrix[currRow++, currCol++] = elementVal++;
            }
        }
        for (int i = 1; i < n; i++)
        {
            currRow = 0;
            currCol = i;

            while (currRow < n && currCol < n)
            {
                matrix[currRow++, currCol++] = elementVal++;
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}\t", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

