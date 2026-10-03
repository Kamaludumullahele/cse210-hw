using System;
class Video
{
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;
    // Constructor and methods for the Video class follow.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
        _comments = new List<Comment>();
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

    public List<Comment> GetComments()
    {
        return _comments;
    }
}