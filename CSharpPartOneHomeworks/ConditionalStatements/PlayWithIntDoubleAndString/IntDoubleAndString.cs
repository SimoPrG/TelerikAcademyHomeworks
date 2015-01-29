//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization;

class IntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Make your choice: \n1 --> int \n2 --> double \n3 --> string");
        Console.Write("Your choice is: ");
        int yourChoice = int.Parse(Console.ReadLine());
        switch (yourChoice)
        {

            case 1: Console.Write("Please enter an int: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Result is: {0}", (inputInt + 1));
                break;
            case 2: Console.Write("Please enter a doudle: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Result is: {0}", (inputDouble + 1));
                break;
            case 3: Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine("Result is: {0}*", inputString);
                break;
            default: Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
