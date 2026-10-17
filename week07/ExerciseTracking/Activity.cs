using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string _date;
        private int _length; // Duration of the activity in minutes

        public Activity(string date, int duration)
        {
            _date = date;
            _length = duration;
        }

        public string GetDate()
        {
            return _date;
        }

        public int GetDuration()
        {
            return _length;
        }
        // Get the distance of the activity in kilometers
        public virtual double GetDistance()  
        {
            return GetSpeed() * _length / 60;
        }
        // Get the speed of the activity in kilometers per hour
        public virtual double GetSpeed()  
        {
            return GetDistance() / _length * 60;
        }
    // Get the pace of the activity in minutes per kilometer
        public virtual double GetPace()
        {
            return _length / GetDistance();
        }
        // Get a summary of the activity including date, type, duration, distance, speed, and pace
        public virtual string GetSummary()
        {
            return $"{_date} {GetType().Name} ({_length} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
    }
}