using System;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
            }
            else if (choice == "3")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
            }
        }
    }
}