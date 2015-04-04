namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double heigth)
        {
            base.Width = width;
            base.Height = heigth;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
