using System;

namespace ExerciseTracking
{
    public class SwimmingInTheLapPool : Activity
    {
        private double _laps; // Number of laps swum
        
        public SwimmingInTheLapPool(string date, int length, double laps) : base(date, length)
        {
            _laps = laps;
        }
        // get the distance based on the number of laps swum
        public override double GetDistance()
        {
            return _laps * 50 / 1000.0; // each lap is 50 meters
        }
    }
}