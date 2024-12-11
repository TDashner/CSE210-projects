using System;

public class Video
{

    public string _title;
    public string _author;
    public int _length;

    private List<Comment> _comment;

    public void Display()
    {
        Console.WriteLine($"{_title} {_author} {_length} seconds, {_comment}");
    }


}
