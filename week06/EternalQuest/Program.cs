// Exceeding requirements (extra credit):
// - NegativeGoal: a repeatable goal for bad habits that subtracts points when recorded.
// - Goals and score are loaded automatically on startup from goals.txt.
// - Checklist goals award bonus points on completion; completed goals show [X].

using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
