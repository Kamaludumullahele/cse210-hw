using System;

namespace EternalQuest
{
    public class Goal
    {
        private string _name;
        private string _description;
        private int _points;

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public virtual void RecordEvent()
        {


        }

        public virtual bool IsComplete()
        {
            return false;
        }
        public virtual string GetDetailString()
        {
            return $"Goal: {_name}, Description = {_description}, Points = {_points}";
        }

        public virtual string GetStringRepresentation()
        {
            return $"Goal: {_name}, Description = {_description}, Points = {_points}";
        }
        public int GetPoints()
        {
            return _points;
        }
        public string GetName() => _name;
        public string GetDescription() => _description;
    }
}