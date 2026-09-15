using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    private string _promptText;
    private string _entryText;

    public Entry(DateTime date, string prompt, string entryText)
    {
        _date = date.ToShortDateString();
        _promptText = prompt;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
    // Saving the entry as a line of text for storage in a file.
    public string ToFileString()
    {// used the | as a simple seperator
        return $"{_date}|{_promptText}|{_entryText}";
    }

    // Loading the entry from a line of text stored in a file.

    public static Entry FromFileString(string fileString)
    {
        string[] parts = fileString.Split('|');
        DateTime date = DateTime.Parse(parts[0]);
        string promptText   = parts[1];
        string entryText = parts[2];
        return new Entry(date, promptText, entryText);
    }
}