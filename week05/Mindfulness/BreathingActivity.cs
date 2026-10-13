using System;
using Mindfulness;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description)
            : base(name, description)
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.Clear();
            Console.WriteLine("Get ready to begin your breathing exercise...");
            ShowSpinner(3); // Show a spinner for 3 seconds before starting the breathing exercise

            int elapsedSeconds = 0;


            while (elapsedSeconds < _duration)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(4);
                Console.WriteLine("..."); // Optional pause or separator between breaths

                Console.WriteLine("Breathe out...");
                ShowCountdown(6);
                Console.WriteLine("..."); // Optional pause or separator between breaths
                elapsedSeconds += 10;
            }
            DisplayEndingMessage();
        }
    }
}