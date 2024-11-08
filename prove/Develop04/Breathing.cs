using System;
using System.Threading.Tasks;
public class BreathingActivity : Activity
{
    public BreathingActivity() :base( "Breathing Activity: This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "You’ve completed the Breathing Activity!"
    ) { }

    protected override async Task ExecuteActivityAsync()
    {
        string[] breathingInstructions = { "Breathe in...", "Breathe out..."};

        int totalCycles = Duration / 5;
        for (int i = 0; i < totalCycles; i++)
        {
            foreach (var instruction in breathingInstructions)
            {
                Console.WriteLine(instruction);
                await PauseAsync(3);
            }
        }
    }
}