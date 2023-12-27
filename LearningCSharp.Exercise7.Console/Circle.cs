namespace LearningCSharp.Exercise7.Console;

public class Circle
{
    public double Radio { get; private set; }

    public Circle(double radio)
    {
        Radio = radio;
    }

    public double CalculateArea()
    {
        double area = Math.PI * Math.Pow(Radio, 2);
        return Math.Round(area, 2);
    }
}