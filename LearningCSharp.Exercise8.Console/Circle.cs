namespace LearningCSharp.Exercise8.Console;

public class Circle : IGeometricFigure
{
    public double Radio { get; set; }

    public Circle(double radio)
    {
        Radio = radio;
    }
    public double CalculateArea()
    {
        double area = Math.Round((Math.PI * Math.Pow(Radio, 2)), 2);
        return area;
    }

    public double CalculatePerimeter()
    {
        double perimeter = Math.Round((2 * Math.PI * Radio), 2);
        return perimeter;
    }
}