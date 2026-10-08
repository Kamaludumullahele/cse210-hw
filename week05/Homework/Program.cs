using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bannet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}