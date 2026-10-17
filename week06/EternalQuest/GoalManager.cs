using System;
using System.Collections.Generic;
using System.Linq;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;
        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
        public void Start()
        {
            LoadGoals(); // Restore the saved score and goals.

            bool running = true;
            while (running)
            {
                DisplayPlayerInfo();
                Console.Write("Select an option: ");
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        ListGoalDetails(); // Display the goals immediately after loading.
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
        }
        public void ListGoalNames()
        {
            Console.WriteLine("Goal Names:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
        }
        public void ListGoalDetails()
        {
            Console.WriteLine($"\nCurrent points: {_score}");
            Console.WriteLine("Goals:");

            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals have been added.");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                string checkbox = goal.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {checkbox} {goal.GetDetailString()}");
            }
        }
        public void CreateGoal()
        {
            Console.WriteLine("Choose a goal type: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Checklist Goal");
            Console.WriteLine("3. Eternal Goal");
            Console.WriteLine("4. Negative Goal");
            int type = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Goal name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            string description = Console.ReadLine() ?? "";

            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine() ?? "0");

            Goal newGoal;

            if (type == 1)
            {
                newGoal = new SimpleGoal(name, description, points);
            }
            else if (type == 2)
            {
                Console.Write("Times needed to complete: ");
                int target = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine() ?? "0");

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
            }
            else if (type == 3)
            {
                newGoal = new EternalGoal(name, description, points);
            }
            else if (type == 4)
            {
                newGoal = new NegativeGoal(name, description, points);
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
                return;
            }

            CreateGoal(newGoal);
            Console.WriteLine("Goal added.");
        }
        public void CreateGoal(Goal goal)
        {
            _goals.Add(goal);
        }
        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("There are no goals to record.");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                string checkbox = _goals[i].IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {checkbox} {_goals[i].GetDetailString()}");
            }

            Console.Write("Select a goal number: ");
            if (!int.TryParse(Console.ReadLine(), out int selection) ||
                selection < 1 || selection > _goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Goal goal = _goals[selection - 1];

            if (goal.IsComplete())
            {
                Console.WriteLine("That goal is already complete.");
                return;
            }

            goal.RecordEvent();

            if (goal is NegativeGoal)
            {
                _score -= goal.GetPoints();
            }
            else
            {
                _score += goal.GetPoints();
            }

            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                Console.WriteLine($"Checklist complete! Bonus: {checklist.GetBonus()} points.");
            }
        }
        public void SaveGoals()
        {
            using var writer = new System.IO.StreamWriter("goals.txt");
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }

            Console.WriteLine("Goals saved to goals.txt.");
        }

        public void LoadGoals()
        {
            if (!System.IO.File.Exists("goals.txt"))
            {
                Console.WriteLine("No saved goals file was found.");
                return;
            }

            string[] lines = System.IO.File.ReadAllLines("goals.txt");
            if (lines.Length == 0 || !int.TryParse(lines[0], out int loadedScore))
            {
                Console.WriteLine("The goals file is invalid.");
                return;
            }

            var loadedGoals = new List<Goal>();

            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split('|');

                if (parts[0] == "SimpleGoal" && parts.Length == 5 &&
                    int.TryParse(parts[3], out int points) &&
                    bool.TryParse(parts[4], out bool complete))
                {
                    var goal = new SimpleGoal(parts[1], parts[2], points);
                    goal.SetComplete(complete);
                    loadedGoals.Add(goal);
                }
                else if (parts[0] == "ChecklistGoal" && parts.Length == 7 &&
                    int.TryParse(parts[3], out points) &&
                    int.TryParse(parts[4], out int amount) &&
                    int.TryParse(parts[5], out int target) &&
                    int.TryParse(parts[6], out int bonus))
                {
                    var goal = new ChecklistGoal(parts[1], parts[2], points, target, bonus);
                    goal.SetAmountCompleted(amount);
                    loadedGoals.Add(goal);
                }
                else if (parts[0] == "EternalGoal" && parts.Length == 4 &&
                    int.TryParse(parts[3], out int eternalPoints))
                {
                    loadedGoals.Add(
                        new EternalGoal(parts[1], parts[2], eternalPoints));
                }
                else if (parts[0] == "NegativeGoal" && parts.Length == 4 &&
                    int.TryParse(parts[3], out int negativePoints))
                {
                    loadedGoals.Add(
                        new NegativeGoal(parts[1], parts[2], negativePoints));
                }
            }

            _goals.Clear();
            _goals.AddRange(loadedGoals);
            _score = loadedScore;
            Console.WriteLine("Goals loaded from goals.txt.");
        }
    }
}