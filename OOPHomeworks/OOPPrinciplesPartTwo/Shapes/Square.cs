namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(double size) : base(size, size)
        {
        }

        public override double CalculateSurface()
        {
            return base.CalculateSurface();
        }

        public override string ToString()
        {
            return "Square";
        }
    }
}
