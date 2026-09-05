using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string score = Console.ReadLine();
        Console.WriteLine($"Your grade percentage: {score}");
        int grade = int.Parse(score);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            if (grade >= 93)
                letter = "A";
            else if (grade < 93)
                letter = "A-";
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade >= 87)
                letter = "B+";
            else if (grade < 83)
                letter = "B-";
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade >= 77)
                letter = "C+";
            else if (grade < 73)
                letter = "C-";
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade >= 67)
                letter = "D+";
            else if (grade < 63)
                letter = "D-";
        }
        else
            letter = "F";

        // mention if the student pass the course or not
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You successfully passed the course.");
            Console.WriteLine($"Your grade: {letter}");
        }
        else
        {
            Console.WriteLine("You did not pass the course.");
            Console.WriteLine($"Your grade: {letter} ");
        }
    }
}