using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program tracks different types of exercises.");
        Console.WriteLine("Summary of exercises:");
        Console.WriteLine();
        ExerciseTracking.Running run = new ExerciseTracking.Running("2024-06-15", 30, 4.8);
        ExerciseTracking.StationaryBicycles bike = new ExerciseTracking.StationaryBicycles("2024-06-15", 45, 20.0);
        ExerciseTracking.SwimmingInTheLapPool swim = new ExerciseTracking.SwimmingInTheLapPool("2024-06-15", 60, 30);

        Console.WriteLine(run.GetSummary() + "\n");
        Console.WriteLine(bike.GetSummary() + "\n");
        Console.WriteLine(swim.GetSummary() + "\n");


    }
}