using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }
        public override string GetDetailString()
        {
            return $"The Goal: {GetName()} - {_amountCompleted}/{_target} completed; bonus: {_bonus}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal: AmountCompleted = {_amountCompleted}, Target = {_target}, Bonus = {_bonus}";
        }

        public int GetBonus()
        {
            return _bonus;
        }

        public int GetAmountCompleted() => _amountCompleted;
        public int GetTarget() => _target;

        public void SetAmountCompleted(int amount)
        {
            _amountCompleted = amount;
        }
    }
}