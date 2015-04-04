namespace DefiningClassesPartTwoHomework
{
    using System;

    public static class CalculateTheDistance
    {
        public static double CalculateTheDistanceBetweenTwoPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt((double)((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X))
                + (double)((firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y))
                + (double)((firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z)));
            return distance;
        }

    }
}
