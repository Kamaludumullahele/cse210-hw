using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            return;
        }
        public override void RecordEvent()
        {
            base.RecordEvent(); // Eternal goals are never complete, so recording an event doesn't change their state
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal: Always incomplete";
        }
    }
}