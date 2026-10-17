using System;

namespace ExerciseTracking
{
    public class StationaryBicycles : Activity
    {   
        private double _speed; // Speed in km/h
        
        public StationaryBicycles(string date, int length, double speed) : base(date, length)
        {
            _speed = speed;
        }
        
        public override double GetSpeed()
        {
            return _speed;
        }
    }
}