using System;

namespace EternalQuest;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor for the SimpleGoal class
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    // Method to record an event related to the simple goal
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Method to check if the simple goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get the string representation of the simple goal
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    // Method to set the completion status of the simple goal
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}
