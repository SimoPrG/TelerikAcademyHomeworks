//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
using System.Threading;
using System.Globalization;

class TriangleSurfaceApp
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please choose a variant to calculate the area of the triangle!");
        Console.WriteLine("Press 1 to calculate by given side and altitude.");
        Console.WriteLine("Press 2 to calculate by given three sides.");
        Console.WriteLine("Press 3 to calculate by given two sides and angle between them.");

        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: CalcAreaBySideAndAltitude(); break;
            case 2: CalcAreaByThreeSides(); break;
            case 3: CalcAreaByTwoSidesAndAngle(); break;

            default: Console.WriteLine("Invalid choice!"); break;
        }
    }

 private static void CalcAreaBySideAndAltitude()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter a side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter an altitude: ");
        double altitude = double.Parse(Console.ReadLine());

        double area = (side * altitude) / 2;
        Console.WriteLine("\nThe aria of the triangle is: {0:F2}", area);
    }

    private static void CalcAreaByThreeSides()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter first side: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter third side: ");
        double sideC = double.Parse(Console.ReadLine());

        double p = (sideA + sideB + sideC) / 2;

        double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        Console.WriteLine("\nThe aria of the triangle is: {0:F2}", area);
    }

   private static void CalcAreaByTwoSidesAndAngle()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter first side: ");
        double sideOne = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double sideTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        double angle = double.Parse(Console.ReadLine());

        double area = ((sideOne * sideTwo) * Math.Sin(angle * Math.PI / 180)) / 2;
        Console.WriteLine("\nThe aria of the triangle is: {0:F2}", area);
    }
}

