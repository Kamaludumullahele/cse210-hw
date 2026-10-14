using System;

namespace Shapes
{
    public abstract class Shape
    {   // Base class for all shapes, contains color and area calculation
        private string _color;
        // Constructor to initialize the color of the shape
        public Shape(string color)
        {
            _color = color;
        }
        // Getter and setter for the color of the shape
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        // Virtual method to calculate the area of the shape, can be overridden by derived classes
        public virtual double GetArea()
        {
            return 0;
        }
    }
}
       