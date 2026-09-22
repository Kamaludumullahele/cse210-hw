using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

    public void HideRandomWords (int numberToHide)
    {
        Random random = new Random();
        for (int index = 0; index < numberToHide && _words.Count > 0; index++)
        {
            _words[random.Next(_words.Count)].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words)}";
    }
}
