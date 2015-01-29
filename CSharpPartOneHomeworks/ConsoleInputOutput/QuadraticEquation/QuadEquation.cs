//Problem 6. Quadratic Equati on

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
//(prints its real roots).

using System;
using System.Threading;
using System.Globalization;

class QuadEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter your quadratic equation ax2 + bx + c = 0!");
        Console.Write("Enter value for coefficient a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter value for coefficient b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter value for coefficient c: ");
        float c = float.Parse(Console.ReadLine());
        if (a == 0) 
        {
            Console.WriteLine("The coefficient a must be a real number and can't be equal to 0!");
            return;
        }
        float d = (float)Math.Pow(b, 2) - 4 * a * c;
        if (d < 0) 
        {
            Console.WriteLine("The equation has no real roots!");
            return;
        }
        if (d == 0)
        {
            Console.WriteLine("The equation has one real root!");
            float x = -(b) / (2 * a);
            Console.WriteLine("x = {0}", x);
        }
        else if (d > 0)
        {
            Console.WriteLine("The equation has two real roots!");
            float x1 = (-(b) - (float)Math.Sqrt(d)) / (2 * a);
            float x2 = (-(b) + (float)Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}

