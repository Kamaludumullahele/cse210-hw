using System;

using System.Collections.Generic;

public class YouTubeVideos
{
    static void Main(string[] args)
    { // create a new video instance and add comments
        Video video1 = new Video("How to Code in C#", "C# coding channel", 245);
        Video video2 = new Video("Cooking with spices", "Emily's Kitchen", 300);
        Video video3 = new Video("Shopping Tips", "Consumer Guide", 180);
        // add comments for video1
        Comment comment1 = new Comment("James Smith", "Great video!");
        Comment comment2 = new Comment("Emily Smith", "Very informative.");
        Comment comment3 = new Comment("Michael Johnson", "Covered most topics well!");
        // add comments for video2
        Comment comment4 = new Comment("Alice Brown", "Loved the recipe!");
        Comment comment5 = new Comment("David Wilson", "Can't wait to try this.");
        Comment comment6 = new Comment("Sophia Davis", "Very helpful tips.");
        // add comments for video3
        Comment comment7 = new Comment("Olivia Martinez", "Very useful shopping tips!");
        Comment comment8 = new Comment("Liam Anderson", "I learned a lot from this video.");
        Comment comment9 = new Comment("Emma Thomas", "Great advice for shoppers.");
        // add comments to video1
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // add comments to video2
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        // add comments to video3
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        Console.WriteLine();
        // adding videos to the list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        // display video details and comments for all videos
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommenterName() + ": " + comment.GetText());
            }
            Console.WriteLine();
            Console.WriteLine("Total Comments: " + video.GetComments().Count);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}