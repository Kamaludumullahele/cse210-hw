using System;
namespace EternalQuest
{
    public class NegativeGoal : Goal
    {
        private bool _isComplete;
        private readonly string _name;
        private readonly string _description;
        private readonly int _points;

        public NegativeGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
            _name = name;
            _description = description;
            _points = points;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }
        public string GetDetailsString()
        {
            return $"[ ] {_name} ({_description}) - Penalty: {_points} points";
        }

        public override string GetStringRepresentation()
        {
            return $"NegativeGoal:{_name},{_description},{_points}";
        }
    }
}