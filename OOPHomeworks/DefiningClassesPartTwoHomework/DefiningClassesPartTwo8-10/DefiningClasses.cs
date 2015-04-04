namespace DefiningClassesPartTwo8_10
{
    using System;

    public class DefiningClasses
    {
        static void Main()
        {
            var matrixOne = new Matrix<int>(3, 3);
            var matrixTwo = new Matrix<int>(3, 3);

            matrixOne[0, 0] = 4;
            matrixOne[0, 1] = 3;
            matrixOne[0, 2] = 6;
            matrixOne[1, 0] = 45;
            matrixOne[1, 1] = 12;
            matrixOne[1, 2] = 75;
            matrixOne[2, 0] = 9;
            matrixOne[2, 1] = 10;
            matrixOne[2, 2] = 41;

            matrixTwo[0, 0] = 5;
            matrixTwo[0, 1] = 17;
            matrixTwo[0, 2] = 9;
            matrixTwo[1, 0] = 148;
            matrixTwo[1, 1] = 4;
            matrixTwo[1, 2] = 30;
            matrixTwo[2, 0] = 1;
            matrixTwo[2, 1] = 958;
            matrixTwo[2, 2] = 487;


            var sum = matrixOne + matrixTwo;
            var dif = matrixOne - matrixTwo;
            var product = matrixOne * matrixTwo;

            Console.WriteLine("Sum: \n{0}", sum);
            Console.WriteLine("Dif: \n{0}", dif);
            Console.WriteLine("Product: \n{0}", product);

            Console.WriteLine(matrixOne ? "Matrix doesn't contain 0.":"Matrix contain 0.");

            matrixOne[1, 1] = 0;

            Console.WriteLine(matrixOne ? "Matrix doesn't contain 0." : "Matrix contain 0.");
        }
    }
}
