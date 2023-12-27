// Write a algorithm than receive the circle's radius and return his area (use classes)

// calculate the area of a circle

// 1. receive radius
// 2. calculate area with radius

using LearningCSharp.Exercise7.Console;

Console.WriteLine("Write the geometric figure 1->Circle and 2->Square");
int figure = int.Parse(Console.ReadLine());

if (figure == 1)
{
    Console.WriteLine("Write circle's radio");
    double radius = double.Parse(Console.ReadLine());
    Circle circle = new Circle(radius);
    double area = circle.CalculateArea();
    Console.WriteLine("The circle's area is " + area);
    
} if (figure == 2)
{
    Console.WriteLine("Write the length of one side");
    double sideLength = double.Parse(Console.ReadLine());
    Square square = new Square(sideLength);
    double squareArea = square.CalculateArea();
    Console.WriteLine("The square's area is " + squareArea);
    
} else{
    Console.WriteLine("Incorrect");
}



