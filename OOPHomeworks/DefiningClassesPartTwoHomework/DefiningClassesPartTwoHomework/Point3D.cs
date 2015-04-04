namespace DefiningClassesPartTwoHomework
{
    using System.Collections.Generic;

    public struct Point3D
    {
        private decimal x;
        private decimal y;
        private decimal z;

        public Point3D(decimal x, decimal y, decimal z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D PointO
        {
            get { return new Point3D(0, 0, 0); }
        }

        public decimal X { get { return this.x; } }

        public decimal Y { get { return this.y; } }

        public decimal Z { get { return this.z; } }

        public override string ToString()
        {
            string result = string.Format("The coordinates of point are: ({0}, {1}, {2})", this.x, this.y, this.z);

            return result;
        }

        public static Point3D Parse(string coordinates)
        {
            var xyz = new List<decimal>();
            string tmpXyz = string.Empty;

            for (int i = 0; i < coordinates.Length; i++)
            {
                if (char.IsDigit(coordinates[i]))
                {
                    while (char.IsDigit(coordinates[i]) || coordinates[i] == '.')
                    {
                        tmpXyz += coordinates[i];
                        i++;
                    }

                    xyz.Add(decimal.Parse(tmpXyz));
                    tmpXyz = string.Empty;
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
