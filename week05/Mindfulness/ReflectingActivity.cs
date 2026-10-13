using System;
using Mindfulness;
using System.Collections.Generic;

namespace Mindfulness
{

    class ReflectingActivity : Activity
    {   // Fields for prompts and questions
        private List<string> _prompts;
        private List<string> _questions;
        public ReflectingActivity(string name, string description)
            : base(name, description)
        {   // Initialization code for the reflecting activity
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            // Initialization code for the questions goes here
            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }
        // Random number generator for selecting prompts and questions
        private readonly Random _random = new Random();

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("\nConsider this prompt:");
            DisplayPrompt();

            System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
            while (stopwatch.Elapsed.TotalSeconds < _duration)
            {
                int remainingSeconds = _duration - (int)stopwatch.Elapsed.TotalSeconds;
                if (remainingSeconds <= 0)
                {
                    break;
                }

                Console.WriteLine();
                DisplayQuestion();
                ShowSpinner(Math.Min(5, remainingSeconds));
            }

            Console.WriteLine();
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }

        public string GetRandomQuestion()
        {
            int index = _random.Next(_questions.Count);
            return _questions[index];
        }

        public void DisplayPrompt()
        {
            Console.WriteLine(GetRandomPrompt());
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(GetRandomQuestion());
        }
    }

}