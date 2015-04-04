namespace DefiningClassesPartTwoHomework
{
    using System;
    using System.Threading;
    using System.Globalization;

    class DefiningClasses
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InstalledUICulture;

            var point = new Point3D(1.3M, 4M, 7.89M);
            var otherPoint = new Point3D(4.5M, 7.14M, 12M);

            Console.WriteLine(point);
            Console.WriteLine(Point3D.PointO);
            Console.WriteLine(CalculateTheDistance.CalculateTheDistanceBetweenTwoPoints(point, otherPoint));

            var sequence = new Path();
            sequence.AddPoint(point);
            sequence.AddPoint(otherPoint);

            Console.WriteLine(sequence);
            PathStorage.SavePath(sequence);

            var otherSequence = PathStorage.LoadPath();

            Console.WriteLine(otherSequence);
        }
    }
}
