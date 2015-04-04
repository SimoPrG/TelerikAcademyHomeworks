namespace DefiningClassesPartTwoHomework
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path sequence)
        {
            using (var file = new StreamWriter(@"..\..\file.txt"))
            {
                file.Write(sequence);
            }
        }

        public static Path LoadPath()
        {
            var path = new Path();

            using (var file = new StreamReader(@"..\..\file.txt"))
            {
                while (!file.EndOfStream)
                {
                    path.AddPoint(Point3D.Parse(file.ReadLine()));
                }
            }

            return path;
        }
    }
}
