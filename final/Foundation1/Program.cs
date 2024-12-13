using System;

class Program
{
    private List<Video> _videos = new List<Video>();
    static void Main(string[] args)
    {
        Video video1 = new Video() { _title = "Rainbow Slime ASMR", _author = "Slimer", _length = 120 };
        Video video2 = new Video() { _title = "How To Code C# In 10 Easy Steps", _author= "How-To-Man", _length = 1800 };
        Video video3 = new Video() { _title = "Why The Sky is Blue", _author= "iWonder", _length = 600 };
        Video video4 = new Video() { _title = "Meal Prep With Me!", _author = "HealthyEating", _length = 3600 };

        video1.AddComment(new Comment("Slime Girly", "This is amazing!"));
        video1.AddComment(new Comment("ASMR Nerd", "I love the sounds."));
        video1.AddComment(new Comment("IsabellaDIY", "Very calming video."));

        video2.AddComment(new Comment("CryptoCat", "Great tutorial!"));
        video2.AddComment(new Comment("JakeCreates", "Thanks for the explanation!"));
        video2.AddComment(new Comment("EthanTechTalk", "Looking forward to part 2."));

        video3.AddComment(new Comment("LukeVenture", "Interesting topic!"));
        video3.AddComment(new Comment("GamerAlex", "I learned a lot."));
        video3.AddComment(new Comment("LifeWithLiam", "Why does the sky really look blue?"));

        video4.AddComment(new Comment("CarlaCooks", "Great meal prep ideas!"));
        video4.AddComment(new Comment("AlexFoodie", "Healthy eating is important!"));
        video4.AddComment(new Comment("FitnessFanatic", "I'm totally saving this to make later."));



        Program program = new Program();
        program._videos.Add(video1);
        program._videos.Add(video2);
        program._videos.Add(video3);
        program._videos.Add(video4);

        foreach (var video in program._videos)
        {
            video.Display();
            Console.WriteLine();
        }








    }
}