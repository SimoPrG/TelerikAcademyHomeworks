namespace DefiningClassesPartTwo8_10
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct, IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[this.rows, this.cols];
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Cols
        {
            get { return this.cols; }
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= this.rows || colIndex < 0 || colIndex >= this.cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.matrix[rowIndex, colIndex];
            }

            set
            {
                if (rowIndex < 0 || rowIndex >= this.rows || colIndex < 0 || colIndex >= this.cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.matrix[rowIndex, colIndex] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            var result = new Matrix<T>(matrixOne.Rows, matrixTwo.Cols);

            if (matrixOne.Rows != matrixTwo.Rows || matrixOne.Cols != matrixTwo.Cols)
            {
                throw new ArgumentException("The first matrix must be the same size as second matrix.");
            }

            for (int row = 0; row < matrixOne.rows; row++)
            {
                for (int col = 0; col < matrixOne.cols; col++)
                {
                    result[row, col] = (dynamic)matrixOne[row, col] + matrixTwo[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            var result = new Matrix<T>(matrixOne.Rows, matrixTwo.Cols);

            if (matrixOne.Rows != matrixTwo.Rows || matrixOne.Cols != matrixTwo.Cols)
            {
                throw new ArgumentException("The first matrix must be the same size as second matrix.");
            }

            for (int row = 0; row < matrixOne.rows; row++)
            {
                for (int col = 0; col < matrixOne.cols; col++)
                {
                    result[row, col] = (dynamic)matrixOne[row, col] - matrixTwo[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Cols != matrixTwo.Rows)
            {
                throw new ArgumentException("The first matrix's cols must be the same size as second matrix's rows.");
            }

            var result = new Matrix<T>(matrixOne.Rows, matrixTwo.Cols);
            dynamic tmpResult = 0;

            for (int i = 0; i < matrixTwo.Cols; i++)
            {
                for (int j = 0; j < matrixOne.Rows; j++)
                {
                    for (int k = 0; k < matrixOne.Cols; k++)
                    {
                        tmpResult += (dynamic)matrixOne[j, k] * matrixTwo[k, i];
                    }

                    result[j, i] = tmpResult;
                    tmpResult = 0;

                }
            }

            return result;
        }

        public static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    result.AppendFormat("{0, 10} ", matrix[row, col]);
                }
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
