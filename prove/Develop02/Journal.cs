using System.ComponentModel;
using System.IO.Compression;

public class Journal
{
    List<Entry> entries = new List<Entry>();

    public void AddEntry()
    {
        Console.WriteLine("prompt");

        Entry entry = new Entry();

        entry.note= Console.ReadLine();
    // look in working with dates in c#
    //add entry to entrylist (entries)

        

// first give user random prompt
// user writing an entry to a file
    }


    public void DisplayEntries()
    {
//The journal displaying the message to the user
    }

    public void Save()
    {
//saving the entries to a file
    }

    public void Load()
    {
//loading from a saved file
    }

}