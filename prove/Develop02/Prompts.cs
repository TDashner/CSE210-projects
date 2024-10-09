public class Prompts
{
    Random random = new Random();
    public List<string> promptList = new List<string>
    {
        "A Moment of Gratitude: Write about a recent experience that made you feel grateful. What happened, who was involved, and how did it impact you?",
        "A Letter to Your Future Self: Imagine you can write a letter to yourself five years from now. What advice, hopes, or reminders would you include?",
        "The Soundtrack of Your Life: If you had to create a playlist that represents your life so far, which five songs would you choose and why?",
        "Exploring a Memory: Choose a childhood memory that stands out to you. Describe it in detail—what you saw, heard, felt, and the emotions it evokes.",
        "Imagining Your Ideal Day: Describe a perfect day in your life, from the moment you wake up to the moment you go to bed. What activities would you include, and who would you spend it with?"

    };

public string RandomPrompt()
{
    string prompt = promptList[random.Next(promptList.Count)];
    return prompt;
}



}