namespace Shapes
{
    using System;

    public class Shapes
    {
        static void Main()
        {
            Shape[] shapes = {
                                 new Triangle(2.5, 4),
                                 new Rectangle(4.7, 8.7),
                                 new Square(5)
                             };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Surface of {0} is: {1}",shape, shape.CalculateSurface());
            }
        }
    }
}
