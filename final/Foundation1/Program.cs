using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Sweet music video", "Death Arcana", 200));
        videos.Add(new Video("Funny meme", "Dead Channel", 20));
        videos.Add(new Video("New Super Mario Brothers Lets Play Part 43", "MarioLover47", 2732));


        videos[0].AddComment("Sweet tunes", "Abby");
        videos[0].AddComment("What a jam!", "Josephine");
        videos[0].AddComment("Pog", "Twitch.tv");

        videos[1].AddComment("Old meme :(", "Blake");
        videos[1].AddComment("CAT!", "Abby");
        videos[1].AddComment("Click this link for free money!", "Scammer");

        videos[2].AddComment("Dude this is the fourth NG+ in this series, pick a new name", "A hater");
        videos[2].AddComment("Please leave the negativity out of my channel.", "MarioLover47");
        videos[2].AddComment("I didn't know you were chill like that g", "A hater");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}