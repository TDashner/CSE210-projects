using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        string choice = "";
        // make 5 into quit
        while (choice != "5")
        {
        // make 1 into write
            if (choice == "1")
            {
                journal.AddEntry();
            }
        }








       // Entry entry1 = new Entry("ASdf", 1, "fdas");

        

        //Console.WriteLine(entry1._date);
        //Console.WriteLine(entry1._note);
        //Console.WriteLine(entry1._prompt);


// journaling prompts:
        //1. A Moment of Gratitude: Write about a recent experience that made you feel grateful. What happened, who was involved, and how did it impact you?
        //2. A Letter to Your Future Self: Imagine you can write a letter to yourself five years from now. What advice, hopes, or reminders would you include?
        //3. The Soundtrack of Your Life: If you had to create a playlist that represents your life so far, which five songs would you choose and why?
        //4. Exploring a Memory: Choose a childhood memory that stands out to you. Describe it in detail—what you saw, heard, felt, and the emotions it evokes.
        //5. Imagining Your Ideal Day: Describe a perfect day in your life, from the moment you wake up to the moment you go to bed. What activities would you include, and who would you spend it with?


        


        
    }
}