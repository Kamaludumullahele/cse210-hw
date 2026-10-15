
// Creativity for Extra Credits:
using System;
namespace EternalQuest
{   
    // Class representing a negative goal in the EternalQuest game
    public class NegativeGoal : Goal
    {
        private bool _isComplete;
        private  string _name;
        private  string _description;
        private  int _points;
    // Constructor for the NegativeGoal class
        public NegativeGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
            _name = name;
            _description = description;
            _points = points;
        }

        // Method to record an event related to the negative goal
        public override void RecordEvent()
        {
            _isComplete = true;
        }

        // Method to check if the negative goal is complete
        public override bool IsComplete()
        {
            return _isComplete;
        }
        public string GetDetailsString()
        {
            return $"[ ] {_name} ({_description}) - Penalty: {_points} points";
        }

        // Method to get the string representation of the negative goal
        public override string GetStringRepresentation()
        {
            return $"NegativeGoal:{_name},{_description},{_points}";
        }
    }
}