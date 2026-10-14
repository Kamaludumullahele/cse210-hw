using System;
using Shapes;

namespace Shapes
{
    public class Circle : Shape
    {   // Derived class representing a circle, inherits from Shape
        private double _radius;

        // Constructor to initialize the color and radius of the circle
        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }
        // Override the GetArea method to calculate the area of the circle
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}