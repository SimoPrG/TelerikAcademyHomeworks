//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Threading;
using System.Globalization;

class PInACirc
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter the coordinates of a point: ");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double radius = 2;
        
        bool check = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2);
        Console.WriteLine("The point {0} inside the circle.", check ? "is" : "is not");
    }
}
