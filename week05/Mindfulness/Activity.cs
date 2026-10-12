using System;

namespace Mindfulness
{
    class Activity
    {
        private string _name;
        private int _duration;
        private string _description;

        public Activity(string name, int duration, string description)
        {
            _name = name;
            _duration = duration;
            _description = description;
            Console.WriteLine($"Initialized {_name} activity with duration {_duration} minutes.");

        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {_name} activity for {_duration} minutes.");
            Console.WriteLine(_description);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine($"Ending {_name} activity. You spent {_duration} minutes on this activity.");
        }
        public void ShowSpinner(int durationSeconds)
        {
            Console.WriteLine("Showing spinner animation for " + durationSeconds + " seconds.");
        }

        public void ShowCountdown(int durationSeconds)
        {
            Console.WriteLine("Showing countdown animation for " + durationSeconds + " seconds.");
        }
    }
}