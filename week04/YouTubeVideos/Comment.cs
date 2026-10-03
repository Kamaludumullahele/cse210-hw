using System;
class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _commentText = text;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _commentText;
    }
}