using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double _distance; // Distance covered in kilometers

        public Running(string date, int length, double distance) : base(date, length)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }
    }
}   