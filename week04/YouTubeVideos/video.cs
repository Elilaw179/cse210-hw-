using System;
using System.Collections.Generic;

class Video
{ 
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }  // Length in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"📺 **Title:** {Title}");
        Console.WriteLine($"✍ **Author:** {Author}");
        Console.WriteLine($"⏳ **Length:** {Length} seconds");
        Console.WriteLine($"💬 **Comments:** {GetCommentCount()}");
        Console.WriteLine("----------------------------------");
        
        foreach (var comment in comments)
        {
            Console.WriteLine($"👉 {comment.Name}: \"{comment.Text}\"");
        }

        Console.WriteLine("\n==================================\n");
    }
}
