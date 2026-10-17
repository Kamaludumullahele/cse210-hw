using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        // Constructor for the EternalGoal class
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            return;
        }

        // Method to record an event related to the eternal goal
        public override void RecordEvent()
        {
            // Eternal goals are never complete, so recording an event doesn't change their state
        }

        // Method to check if the eternal goal is complete
        public override bool IsComplete()
        {
            return false;
        }

        // Method to get the string representation of the eternal goal
        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
        }
    }
}