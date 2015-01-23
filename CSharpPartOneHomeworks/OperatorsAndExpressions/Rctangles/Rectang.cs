//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectang
{
    static void Main()
    {
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

