namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public abstract double CalculateSurface();

        public double Width { get; set; }

        public double Height { get; set; }
    }
}
