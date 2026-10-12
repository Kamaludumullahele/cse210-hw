using System;
using Mindfulness;
using System.Collections.Generic;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;
        public BreathingActivity(string name, int duration, string description)
            : base(name, duration, description)
        {
            // Initialization code for the breathing activity goes here
        }

        public void Run()
        {
            // Run the breathing activity sequence goes here
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
        
        public List<string> GetListFromUser(List<string>prompts)
        {
            _prompts = prompts;  
            return _prompts;
        }
    }
}