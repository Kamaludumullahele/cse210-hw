using System;
using System.Collections.Generic;

class Program
{
    // Main entry point of the program, handling user input and scripture display
    static void Main(string[] args)
    {   
        Console.Write("Enter the Scripture reference (for example, John 3:16-18): ");
        string referenceInput = Console.ReadLine();
        Console.WriteLine("Enter the Scripture text one verse per line.");
        Console.WriteLine("Press Enter on an empty line when finished:");
        // Read the scripture text from the user, line by line
        List<string> textLines = new List<string>();
        string textLine;
        while (!string.IsNullOrWhiteSpace(textLine = Console.ReadLine()))
        {
            textLines.Add(textLine);
        }
        // Combine the lines into a single string representing the full scripture text
        string text = string.Join(" ", textLines);
        Console.WriteLine();

        if (string.IsNullOrWhiteSpace(referenceInput) || string.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine("The reference and scripture text are required.");
            return;
        }
        // Parse the reference input into its components (book, chapter, verse, and optional end verse)
        string[] referenceParts = referenceInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (referenceParts.Length != 2 || !referenceParts[1].Contains(':'))
        {
            Console.WriteLine("Use a reference like John 3:16 or John 3:16-18.");
            return;
        }
        // Extract the book name and chapter/verse information from the reference parts
        string book = referenceParts[0];
        string[] chapterVerse = referenceParts[1].Split(':');
        if (chapterVerse.Length != 2 || !int.TryParse(chapterVerse[0], out int chapter))
        {
            Console.WriteLine("The chapter must be a number.");
            return;
        }
        // Extract the verse and optional end verse from the chapter/verse information
        string[] verseParts = chapterVerse[1].Split('-');
        if (!int.TryParse(verseParts[0], out int verse))
        {
            Console.WriteLine("The verse must be a number.");
            return;
        }
        // Create the Reference object based on the parsed chapter, verse, and optional end verse
        Reference reference;
        if (verseParts.Length == 2 && int.TryParse(verseParts[1], out int endVerse))
        {
            reference = new Reference(book, chapter, verse, endVerse);
        }
        else if (verseParts.Length == 1)
        {
            reference = new Reference(book, chapter, verse);
        }
        else
        {
            Console.WriteLine("The verse range must look like 16-18.");
            return;
        }

        // Create the Scripture object with the reference and text
        Scripture scripture = new Scripture(reference, text);
        // Loop to repeatedly hide words until all are hidden or the user quits
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type quit to stop:");

            string input = Console.ReadLine();
            if (input == null || input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        // Display the final state of the scripture after all words are hidden
        Console.Clear();
        Console.WriteLine("All words are now hidden.");
        Console.WriteLine();
        Console.WriteLine(scripture.GetDisplayText());
    }
}