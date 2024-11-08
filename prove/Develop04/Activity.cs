using System;
using System.Threading;
using System.Threading.Tasks;

public abstract class Activity
{
    protected int Duration { get; set; }
    protected string StartMessage { get; set; }
    protected string EndMessage { get; set; }

    public Activity(string startMessage, string endMessage)
    {
        StartMessage = startMessage;
        EndMessage = endMessage;
    }

    public async Task StartAsync()
    {
        Console.Clear();
        Console.WriteLine(StartMessage);
        Console.WriteLine("How many seconds would you like to set for this activity?");

        int inputDuration;

        while (!int.TryParse(Console.ReadLine(), out inputDuration) || Duration <= 0)
        {
            Console.WriteLine("Please enter a valid number of seconds greater than 0.");
            break;
        }

        Console.WriteLine("Get ready to begin...");
        await PauseAsync(3);

        await ExecuteActivityAsync();

        Console.Clear();
        Console.WriteLine(EndMessage);
        Console.WriteLine($"Great Job! You completed this activity in {Duration} seconds.");
        await PauseAsync(3);
    }

    protected abstract Task ExecuteActivityAsync();

    protected async Task PauseAsync(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            await Task.Delay(1000);  // Replaced Thread.Sleep with Task.Delay
        }
        Console.WriteLine();
    }
}
