using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the Square class
        Square square = new Square("Red", 4.0);
        Console.WriteLine($"Color: {square.GetColor()}, Area: {square.GetArea()}");

        // Test the Rectangle c;ass 
        Rectangle rectangle = new Rectangle("Blue", 5.0, 3.0);
         Console.WriteLine($"Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        // Test the Circle class
        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate through the list of shapes and display their color and area
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

    }
    
}