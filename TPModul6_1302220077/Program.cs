using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null || title.Length > 100)
        {
            throw new ArgumentException("Judul video harus memiliki panjang maksimal 100 karakter dan tidak boleh null.");
        }

        Random random = new Random();
        id = random.Next(10000, 99999);

        this.title = title!;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        
        if (count > 0 && playCount > int.MaxValue - count)
        {
            throw new OverflowException("Penambahan play count melebihi batas maksimum.");
        }
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

        try
        {
            SayaTubeVideo video = new SayaTubeVideo(null); 
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            string longTitle = new string('a', 101);
            SayaTubeVideo video = new SayaTubeVideo(longTitle);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        SayaTubeVideo video2 = new SayaTubeVideo($"Tutorial Design By Contract - {namaPraktikan}");
        for (int i = 0; i < 2; i++)
        {
            try
            {
                video2.IncreasePlayCount(2000000000);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        video2.PrintVideoDetails();
    }
}
