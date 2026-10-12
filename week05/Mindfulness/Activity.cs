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
        }

        public void DisplayStartingMessage()
        {
            // Display the starting message goes here
        }

        public void DisplayEndingMessage()
        {
            // Display the ending message goes here
        }
        public void ShowSpinner(int durationSeconds)
        {
            // Display the spinner animation goes here
        }

        public void ShowCountdown(int durationSeconds)
        {
            // Display the countdown animation goes here
        }
    }
}