using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 99999);

        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string namaPraktikan = "Helmy Farikh Alfarizhi";

        SayaTubeVideo video = new SayaTubeVideo($"Tutorial Design By Contract - {namaPraktikan}");

        video.IncreasePlayCount(60);

        video.PrintVideoDetails();
    }
}

