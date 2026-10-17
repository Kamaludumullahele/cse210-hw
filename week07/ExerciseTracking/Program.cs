using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program tracks different types of exercises.");
        Console.WriteLine("Summary of exercises:");
        Console.WriteLine();
        List<ExerciseTracking.Activity> activities = new List<ExerciseTracking.Activity>
        {
            new ExerciseTracking.Running("2024-06-15", 30, 4.8),
            new ExerciseTracking.StationaryBicycles("2024-06-15", 45, 20.0),
            new ExerciseTracking.SwimmingInTheLapPool("2024-06-15", 60, 30)
        };

        foreach (ExerciseTracking.Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

    }
}