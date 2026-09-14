using System;
using System.Collections.Generic;
using Journal;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Console.WriteLine($"{promptGenerator.GetRandomPrompt()}");
        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();
        
    }
}