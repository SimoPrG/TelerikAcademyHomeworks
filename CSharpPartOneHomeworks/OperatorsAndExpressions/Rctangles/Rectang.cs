//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Threading;
using System.Globalization;

class Rectang
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter reactangle's width and height!");
        Console.Write("Width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Height: ");
        float height = float.Parse(Console.ReadLine());
        float perim = 2 * (width + height);
        float area = (width * height);
        Console.WriteLine("Rectangle's perimeter is: " + perim);
        Console.WriteLine("Rectangle's area is: " + area);

    }
}

