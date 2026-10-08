using System;
using Homework;

namespace Homework
{  //
    public class WritingAssignment : Assignment
    {
        private string _title;
        // Constructor for the WritingAssignment class
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            _title = title;
        }
        // Method to get writing information
        public string GetWritingInformation()
        {
            return $"{_title} by {_studentName}";
        }
        // Method to get a summary of the writing assignment
        public string GetSummary(string studentName, string topic)
        {
            return $"{studentName} - {topic}.";
        }
    }
}