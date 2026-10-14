using System;
using Shapes;

namespace Shapes
{
    public class Rectangle : Shape
    {   // Derived class representing a rectangle, inherits from Shape
        private double _width;
        private double _height;

        // Constructor to initialize the color, width, and height of the rectangle
        public Rectangle(string color, double width, double height) : base(color)
        {
            _width = width;
            _height = height;
        }
        // Override the GetArea method to calculate the area of the rectangle
        public override double GetArea()
        {
            return _width * _height;
        }
    }
}