using System;
using System.Diagnostics;
using System.Threading;

namespace Mindfulness
{
    class Activity
    { // Base class for mindfulness activities
        protected string _name;
        protected string _description;
        protected int _duration;

        // Constructor for the base activity class
        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;

        }
        // Method to display the starting message and prompt for duration
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name} activity!\n");
            Console.WriteLine(_description);
            Console.WriteLine("\nHow long would you like to spend on this activity in seconds?");
            string input = Console.ReadLine();
            _duration = int.Parse(input);
        }
        // Method to display the ending message
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Well done!");
            Thread.Sleep(3000); // Pause for a moment before displaying the ending message
            Console.WriteLine($"Ending {_name} activity. You spent {_duration} seconds on this activity.");
        }

        // Method to show a spinner animation for a specified duration
        public void ShowSpinner(int durationSeconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            Stopwatch stopwatch = Stopwatch.StartNew();
            int spinnerIndex = 0;

            while (stopwatch.Elapsed.TotalSeconds < durationSeconds)
            {
                Console.Write($"\b{spinner[spinnerIndex]}");
                // Move to the next spinner character
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                Thread.Sleep(100);
            }

            Console.Write("\b \b");

        }

        public void ShowCountdown(int durationSeconds)
        {
            for (int i = durationSeconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}