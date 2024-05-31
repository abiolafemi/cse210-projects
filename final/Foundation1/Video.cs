using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string getTitle()
    {
        return _title;
    }

    public string getAuthor()
    {
        return _author;
    }

    public int getLength()
    {
        return _length;
    }

    public int getCommentCount()
    {
        return _comments.Count;
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> getComments()
    {
        return _comments;
    }
}
