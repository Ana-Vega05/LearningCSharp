namespace LearningCSharp.Exercise7.Console;

public class Square
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
    
}