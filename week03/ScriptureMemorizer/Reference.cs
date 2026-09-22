using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // Constructor for a reference with a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for a reference with a range of verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    // Method to get the display text of the reference
    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter} {_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter} {_verse}";
        }
    }
}