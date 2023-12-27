namespace LearningCSharp.Exercise8.Console;

public class Rectangle : IGeometricFigure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;

    }
    
    public double CalculateArea()
    {
        double area = Math.Round((Width * Height), 2);
        return area;
    }

    public double CalculatePerimeter()
    {
        double perimeter = Math.Round(((2 * Width) + (2 * Height)), 2);
        return perimeter;
    }
}