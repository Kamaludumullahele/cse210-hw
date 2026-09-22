using System;

class Program
{
    private string _book = "";
    private int _chapter;
    private int _verse;
    private int _endVerse;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }
    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter} {_verse} {_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter} {_verse}";
        }
    }


}