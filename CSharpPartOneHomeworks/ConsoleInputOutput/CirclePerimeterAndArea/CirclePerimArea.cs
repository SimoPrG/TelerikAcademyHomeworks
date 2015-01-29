//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area 
//formatted with 2 digits after the decimal point.

using System;
using System.Threading;
using System.Globalization;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter radius of a circle: ");
            float radius = float.Parse(Console.ReadLine());
            float perimeter = 2F * (float)Math.PI * radius;
            float area = (float)Math.PI * (float)Math.Pow(radius, 2);

            Console.WriteLine("The perimeter of the cirle is: {0:0.00}", perimeter);
            Console.WriteLine("The area of the circle is: {0:0.00}", area);
        }
    }

