using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // 📌 Create Videos
        Video video1 = new Video("C# Basics for Beginners", "John Doe", 600);
        Video video2 = new Video("Object-Oriented Programming in C#", "Jane Smith", 900);
        Video video3 = new Video("How to Build a C# Console App", "Mike Brown", 750);

        // 📌 Add Comments to Videos
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This helped me a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make more tutorials?"));

        video2.AddComment(new Comment("Daniel", "OOP is powerful!"));
        video2.AddComment(new Comment("Emma", "I finally understand this, thanks!"));
        video2.AddComment(new Comment("Frank", "Clear and concise!"));

        video3.AddComment(new Comment("Grace", "Step-by-step guide, awesome!"));
        video3.AddComment(new Comment("Henry", "I appreciate this tutorial."));
        video3.AddComment(new Comment("Ivy", "What software do you use for coding?"));

        // 📌 Add Videos to List
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // 📌 Display Videos and Comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
