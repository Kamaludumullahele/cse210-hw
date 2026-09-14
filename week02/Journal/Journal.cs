using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public Journal(List<Entry> entries)
    {
        _entries = entries;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There is no entry to show in the Journal.");
            return;
        }


        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.WriteLine("All journal entries displayed.");

    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = Entry.FromFileString(line);
            _entries.Add(entry);
            entry.DisplayEntry();
        }
        Console.WriteLine("Journal loaded successfully.");
    }

}