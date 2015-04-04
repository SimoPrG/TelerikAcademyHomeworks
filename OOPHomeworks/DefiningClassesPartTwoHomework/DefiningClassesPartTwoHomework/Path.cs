namespace DefiningClassesPartTwoHomework
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.sequence = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var point in this.sequence)
            {
                result.AppendLine(point.ToString());
            }
            return result.ToString();
        }
    }
}
