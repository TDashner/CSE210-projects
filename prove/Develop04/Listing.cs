using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        "You’ve completed the Listing Activity!"
    ){}

    protected override async Task ExecuteActivityAsync()
    {
        var prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);

        await PauseAsync(3);
        Console.WriteLine("Start listing items now...");
        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Type an item (or type 'done' to stop):");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item)) continue;

            userItems.Add(item);
            Console.WriteLine("Keep going...");
            await PauseAsync(1); // brief pause between items
        }

        Console.WriteLine($"You listed {userItems.Count} items!");
    }
}