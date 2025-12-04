using System;

class Video
{
    private double _length;
    private string _title;
    private string _author;

    private List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author,double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string comment)
    {
        Comment my_comment = new Comment(name,comment);
        _commentList.Add(my_comment);
    }

    public int GetCommentNumber()
    {
        int CommentNumber = _commentList.Count;
        return CommentNumber;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_title} by {_author}: {_length} minutes");
    }

    public void DisplayCommentList()
    {
        foreach (Comment item in _commentList)
        {
            item.DisplayComment();
        }
    }
}