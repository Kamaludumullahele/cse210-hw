using System;

namespace Homework
{
    public class Assignment
    {
        // Private fields for the student's name and the assignment topic
        protected string _studentName;
        private string _topic;
        // Constructor for the Assignment class
        public Assignment(string studentName, string topic)
        { // Initialize the private fields with the provided values
            _studentName = studentName;
            _topic = topic;
        }
        // Method to get a summary of the assignment
        public string GetSummary()
        {
            return $"{_studentName} is working on {_topic}.";
        }
    }
}