using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;
        // Constructor for the ChecklistGoal class
        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        // Method to record an event related to the checklist goal
        public override void RecordEvent()
        {
            _amountCompleted++;
        }
        // Method to check if the checklist goal is complete
        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }
        // Method to get the details of the checklist goal as a string
        public override string GetDetailString()
        {
            return $"The Goal: {GetName()} - {_amountCompleted}/{_target} completed; bonus: {_bonus}";
        }
        // Method to get the string representation of the checklist goal
        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal: AmountCompleted = {_amountCompleted}, Target = {_target}, Bonus = {_bonus}";
        }
        // Method to get the bonus points of the checklist goal
        public int GetBonus()
        {
            return _bonus;
        }
        // Method to get the amount completed of the checklist goal
        public int GetAmountCompleted() => _amountCompleted;

        // Method to get the target of the checklist goal
        public int GetTarget() => _target;

        // Method to set the amount completed of the checklist goal
        public void SetAmountCompleted(int amount)
        {
            _amountCompleted = amount;
        }
    }
}