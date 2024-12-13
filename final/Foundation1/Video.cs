using System;

public class Video
{

    public string _title;
    public string _author;
    public int _length;

    private List<Comment> comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}\n Author: {_author} \n Length: {_length} seconds \n Number of comments: {GetCommentCount()}");

        foreach (var comment in comments)
        {
            comment.Display();
        }
    }

}
