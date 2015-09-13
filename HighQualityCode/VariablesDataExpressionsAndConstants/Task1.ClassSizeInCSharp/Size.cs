using System;

public class Size
{
    private double width, height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public static Size GetRotatedSize(Size size, double angleToRotate)
    {
        double widthAfterRotate = Math.Abs(Math.Cos(angleToRotate)) * size.width + Math.Abs(Math.Sin(angleToRotate) * size.height);
        double heightAfterRotate = Math.Abs(Math.Sin(angleToRotate)) * size.width + Math.Abs(Math.Cos(angleToRotate) * size.height);
        Size sizeAfterRotate = new Size(widthAfterRotate, heightAfterRotate);

        return sizeAfterRotate;
    }
}