namespace LearningCSharp.Exercise8.Console;

public class Square : IGeometricFigure
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }
    
    public double CalculateArea()
    {
        double area = Math.Round((SideLength * SideLength), 2);
        return area;
    }

    public double CalculatePerimeter()
    {
        double perimeter = Math.Round((4 * SideLength), 2);
        return perimeter;
    }
}