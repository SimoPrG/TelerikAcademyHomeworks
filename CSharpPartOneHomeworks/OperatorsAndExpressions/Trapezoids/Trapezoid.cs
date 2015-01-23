//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Enter the tarpezoid's two base lengths and the height!");
        Console.Write("Base One: ");
        double base1 = double.Parse(Console.ReadLine());
        Console.Write("Base Two: ");
        double base2 = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((base1 + base2) / 2) * height;
        Console.WriteLine("The trapezoid's area is: " + area);
    }
}

