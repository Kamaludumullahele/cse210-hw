using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their first and last name
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        //prompt the user for their last name
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

    }
}