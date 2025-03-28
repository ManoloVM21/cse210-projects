using System;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n  ");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Making mofongo","Skrillex",400);
        Video video2 = new Video("Ice-Bucket Challenge","Willyrex",1000);
        Video video3 = new Video("Squid-Game","Mr. Beast",11500);

        video1.AddComment("Jose1234","That's sounds really good!");
        video1.AddComment("Anonymous555","I hate it.");
        video1.AddComment("ponystar6007","Skrillex 2010 was better");


        video2.AddComment("Mariah_rockstar","that's so dumb");
        video2.AddComment("halo456732","Willy's so funny");
        video2.AddComment("noonecares","where's vegeta???");

        video3.AddComment("noideausername","not even close to the original serie");
        video3.AddComment("lackedofnames777","dont know why I saw this");
        video3.AddComment("Daniel_DARK666","Mr. Beast the Best!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos){
            video.Display();
        }

    }
}