using System.ComponentModel;
using System.IO.Compression;

public class Journal
{
    List<Entry> entries = new List<Entry>();
    string filePath = "savedText.txt";
    Prompts prompts = new Prompts();
    public void AddEntry()
    {
        string prompt = prompts.RandomPrompt();
        Console.WriteLine(prompt);

        Console.Write(">");
        string note = Console.ReadLine();

        Entry entry = new Entry(note, DateTime.Now.ToShortDateString(), prompt);
        int note = Convert.ToInt32(Console.ReadLine());
        entries.Add(entry);

    // look in working with dates in c#
    //add entry to entrylist (entries)

        

// first give user random prompt
// user writing an entry to a file
    }


    public void DisplayEntries()
    {
        foreach(var entry in entries)
        {
            Console.WriteLine($"{entry.date} {entry.prompt} {entry.note}");
        }
//The journal displaying the message to the user
    }

    public void Save()
    {
        string fileName = "savedText.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This is your saved inputs: ");
        }
//saving the entries to a file
    }

    public void Load()
    {
        
//loading from a saved file
    }

}