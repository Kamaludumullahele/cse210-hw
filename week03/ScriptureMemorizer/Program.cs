using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Enter the Scripture reference (for example, John 3:16-18): ");
        string referenceInput = Console.ReadLine();
        Console.WriteLine("Enter the Scripture text one verse per line.");
        Console.WriteLine("Press Enter on an empty line when finished:");

        List<string> textLines = new List<string>();
        string textLine;
        while (!string.IsNullOrWhiteSpace(textLine = Console.ReadLine()))
        {
            textLines.Add(textLine);
        }

        string text = string.Join(" ", textLines);
        Console.WriteLine();

        if (string.IsNullOrWhiteSpace(referenceInput) || string.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine("The reference and scripture text are required.");
            return;
        }

        string[] referenceParts = referenceInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (referenceParts.Length != 2 || !referenceParts[1].Contains(':'))
        {
            Console.WriteLine("Use a reference like John 3:16 or John 3:16-18.");
            return;
        }

        string book = referenceParts[0];
        string[] chapterVerse = referenceParts[1].Split(':');
        if (chapterVerse.Length != 2 || !int.TryParse(chapterVerse[0], out int chapter))
        {
            Console.WriteLine("The chapter must be a number.");
            return;
        }

        string[] verseParts = chapterVerse[1].Split('-');
        if (!int.TryParse(verseParts[0], out int verse))
        {
            Console.WriteLine("The verse must be a number.");
            return;
        }

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

        Scripture scripture = new Scripture(reference, text);

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

        Console.Clear();
        Console.WriteLine("All words are now hidden.");
        Console.WriteLine();
        Console.WriteLine(scripture.GetDisplayText());
    }
}