using System;
using System.Collections.Generic;
using System.Linq;
// Class representing a scripture passage, consisting of a reference and a list of words
public class Scripture
{ 
    private Reference _reference;
    private List<Word> _words;

    // Constructor for the Scripture class, initializing the reference and splitting the text into words
    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }
    // Method to hide a specified number of random words in the scripture
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

    // Method to get the display text of the scripture, showing hidden words as underscores
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    // Method to check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
