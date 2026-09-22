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
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        for (int index = 0; index < numberToHide && visibleWords.Count > 0; index++)
        {
            int wordIndex = random.Next(visibleWords.Count);
            Word wordToHide = visibleWords[wordIndex];
            wordToHide.Hide();
            visibleWords.RemoveAt(wordIndex);
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
