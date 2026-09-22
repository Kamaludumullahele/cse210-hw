using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Enter the Scripture reference (e.g., John 3:16): ");
        string referenceInput = Console.ReadLine();
        Console.WriteLine("Enter the Scripture text: ");
        string text = Console.ReadLine();

        // Parse the reference input
        string[] referenceParts = referenceInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string book = referenceParts[0];
        string[] chapterVerse = referenceParts[1].Split(':');
        int chapter = int.Parse(chapterVerse[0]);
        int verse = int.Parse(chapterVerse[1]);
        Reference reference = new Reference(book, chapter, verse);

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type quit to stop:");

            string input = Console.ReadLine();
            if (input == null || input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}