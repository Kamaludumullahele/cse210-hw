public class Word
{ // Class representing a single word in the scripture, which can be hidden or shown
	private string _text;
	private bool _isHidden;

    // Constructor for the Word class, initializing the word text and setting it as visible by default
	public Word(string text)
	{
		_text = text;
        _isHidden = false;
	}
    // Method to hide the word
	public void Hide()
	{
		_isHidden = true;
	}

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text of the word, showing underscores if hidden
	public string GetDisplayText()
	{
		return _isHidden ? new string('_', _text.Length) : _text;
	}
}
