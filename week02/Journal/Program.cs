using System;
using System.Collections.Generic;
using JournalApp;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;
        while (running)

        {
            Console.WriteLine("Wellcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine($"You selected option {choice}");
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("Enter your response:");
                    string response = Console.ReadLine();
                    // For creativity I have added DateTime to track when the entry was made.
                    Entry entry = new Entry(DateTime.Now, prompt, response);
                    journal.addEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to load:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine($"Journal loaded from {loadFileName}");
                    Console.WriteLine($"Journal loaded successfully from {loadFileName}");
                    break;
                case "4":
                    Console.WriteLine("Enter the filename to save:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // End of switch statement

        }
    }
}