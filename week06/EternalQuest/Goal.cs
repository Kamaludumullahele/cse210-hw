using System;

namespace EternalQuest
{
    public class Goal
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
        public virtual void RecordEvent()
        {
            
        }
        // Method to check if the goal is complete
        public virtual bool IsComplete()
        {
            return false;
        }
        // Method to get the details of the goal as a string
        public virtual string GetDetailString()
        {
            return $"Goal: {_name}, Description = {_description}, Points = {_points}";
        }
        // Method to get the string representation of the goal
        public virtual string GetStringRepresentation()
        {
            return $"Goal: {_name}, Description = {_description}, Points = {_points}";
        }
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