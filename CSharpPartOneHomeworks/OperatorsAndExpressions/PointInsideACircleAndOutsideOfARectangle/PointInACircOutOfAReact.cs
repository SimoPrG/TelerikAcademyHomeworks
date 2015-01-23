//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Threading;
using System.Globalization;

class PointInACircOutOfAReact
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter the coordinates of a point: ");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;

        bool checkInCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(radius, 2);
        bool checkInRectangle = (x < -1 || x > 5 || y < -1 || y > 1);
        if (checkInCircle == true && checkInRectangle == true)
        {
            Console.WriteLine("The point is inside a circle and outside a rectangle!!!");
        }
        else 
        {
            if (checkInCircle == false && checkInRectangle == false)
            {
                Console.WriteLine("The point is outside a circle and inside a rectangle!!!");
            }
            else 
            {
                if (checkInCircle == true && checkInRectangle == false) 
                {
                    Console.WriteLine("The point is inside a circle and a rectangle!!!");
                }
                else if (checkInCircle == false && checkInRectangle == true)
                    {
                        Console.WriteLine("The point is outside a circle and a rectangle!!!");
                    }
            }
        }
    }
}

