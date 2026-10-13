using System;
using Mindfulness;

namespace Mindfulness
{
    class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        // Constructor for the listing activity
        public ListingActivity(string name, string description)
            : base(name, description)
        {
            _count = 0;
            _prompts = new List<string>
            {
                "List as many things as you can that you are grateful for.",
                "List as many personal strengths as you can.",
                "List as many activities that make you happy as you can.",
                "Who are the people that you appreciate?",
                "What are the personal strengths that you possess?",
                "What are the things that bring you joy?",
                "Who are the people that you have helped this week?",
                "When have you felt the Holy Ghost this month?"
            };
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        public List<string> GetListFromUser()
        {
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                    _count++;
                }
            }
            return items;
        }
        public void Run()
        {
            DisplayStartingMessage();
            string prompt = GetRandomPrompt();
            Console.WriteLine($"\n{prompt}");
            Console.WriteLine("You may begin listing items now:");

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.ReadLine();
                _count++;
            }

            Console.WriteLine($"\nYou listed {_count} items.");
            DisplayEndingMessage();
        }
    }
}