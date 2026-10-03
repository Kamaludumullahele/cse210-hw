using System;
class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<string> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
        _comments = new List<string>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _lengthInSeconds;
    }

    public List<string> GetComments()
    {
        return _comments;
    }
}