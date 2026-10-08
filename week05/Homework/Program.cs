using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment assignment = new Assignment("Samuel Bannet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("--------------------------------------------------");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "Europian History", "The Causes of World War II");   
        Console.WriteLine(writingAssignment.GetSummary("Mary Waters", "Europian History"));
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine("--------------------------------------------------");
    }
}