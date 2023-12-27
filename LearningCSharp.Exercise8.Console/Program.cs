// Define an interface that represents a geometric figure
// with the methods for get area and perimeter of a figure and implement a square, a circle and rectangle

// 1. Define an interface with its methods 
// 2. create class of square, circle and rectangle
// 3. and in this class define the behavior 

using LearningCSharp.Exercise8.Console;

Console.WriteLine("Write 1 -> Square, 2 -> Circle and 3 -> Rectangle");
int figure = int.Parse(Console.ReadLine());

if (figure == 1)
{
    Console.WriteLine("Write the length of side");
    double sideLength = double.Parse(Console.ReadLine());
    Square square = new Square(sideLength);
    double squareArea = square.CalculateArea();
    Console.WriteLine("Area's square is: " + squareArea);
    double squarePerimeter = square.CalculatePerimeter();
    Console.WriteLine("Perimeter's square is: " + squarePerimeter);
}

else if (figure == 2)
{
    Console.WriteLine("Write the radio's circle");
    double radio = double.Parse(Console.ReadLine());
    Circle circle = new Circle(radio);
    double circleArea = circle.CalculateArea();
    Console.WriteLine("Area's circle is: " + circleArea);
    double circleperimeter = circle.CalculatePerimeter();
    Console.WriteLine("Perimeter's circle is: " + circleperimeter);
}

else if (figure == 3)
{

    Console.WriteLine("Write the width's rectangle");
    double width = double.Parse(Console.ReadLine());
    Console.WriteLine("Write heigth's rectangle");
    double heigth = double.Parse(Console.ReadLine());
    Rectangle rectangle = new Rectangle(width, heigth);
    double rectangleArea = rectangle.CalculateArea();
    Console.WriteLine("Area's rectangle is: " + rectangleArea);
    double rectanglePerimeter = rectangle.CalculatePerimeter();
    Console.WriteLine("Perimeter's rectangle is: " + rectanglePerimeter);
}
else
{
    //Console.WriteLine("none matches");
}