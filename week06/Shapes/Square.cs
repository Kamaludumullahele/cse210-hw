using System;
using Shapes;

namespace Shapes
{
    public class Square : Shape
    {   // Derived class representing a square, inherits from Shape 
        private double _side;

        // Constructor to initialize the color and side of the square
        public Square(string color, double side) : base(color)
        {
            _side = side;
        }
        // Override the GetArea method to calculate the area of the square
        public override double GetArea()
        {
            return _side * _side;
        }
    }
}