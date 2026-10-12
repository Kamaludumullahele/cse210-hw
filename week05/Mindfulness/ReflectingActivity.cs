using System;
using Mindfulness;
using System.Collections.Generic;

namespace Mindfulness
{
    
    class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity(string name, int duration, string description)
            : base(name, duration, description)
        {
            // Initialization code for the reflecting activity goes here
        }

        public void Run()
        {
            // Run the reflecting activity sequence goes here
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(_questions.Count);
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