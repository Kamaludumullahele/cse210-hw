using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        private string _name;
        private string _description;
        private int _points;
        // Constructor for the Goal class
        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }
        // Method to record an event related to the goal
        public abstract void RecordEvent();
        // Method to check if the goal is complete
        public abstract bool IsComplete();
        // Method to get the details of the goal as a string
        public virtual string GetDetailString()
        {
            return $"{_name} ({_description})";
        }
        // Method to get the string representation of the goal
        public abstract string GetStringRepresentation();
        // Method to get the points of the goal
        public int GetPoints()
        {
            return _points;
        }

        // Method to get the name of the goal
        public string GetName() => _name;

        // Method to get the description of the goal
        public string GetDescription() => _description;
    }
}