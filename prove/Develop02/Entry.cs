public class Entry
{

    // DateTime theCurrentTime = DateTime.Now;
    // string dateText = theCurrentTime.ToShortDateString();
    public string note;
    public string date;
    public string prompt;

    // constructor, sets your attributes
    public Entry(string note, string date, string prompt)
    {
        this.note = note;
        this.date = date;
        this.prompt = prompt;
    }

    // public void write()
    // {

    // }
}