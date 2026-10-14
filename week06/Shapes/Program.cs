using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // Create instances of different shapes
        Shapes.Square square = new Shapes.Square("Red", 5);
        
        Shapes.Circle circle = new Shapes.Circle("Blue", 3);
        
        Shapes.Rectangle rectangle = new Shapes.Rectangle("Green", 4, 6);
        // Add the shapes to a list for easier iteration
        List<Shapes.Shape> shapes = new List<Shapes.Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shapes.Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} shape is {shape.GetArea()}");
        }
    }
}