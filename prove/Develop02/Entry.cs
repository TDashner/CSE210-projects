public class Entry
{

    // DateTime theCurrentTime = DateTime.Now;
    // string dateText = theCurrentTime.ToShortDateString();
    public string note;
    public int date;
    public string prompt;

    // constructor, sets your attributes
    public Entry(string note, int date, string prompt)
    {
        this.note = note;
        this.date = date;
        this.prompt = prompt;
    }

    // public void write()
    // {

    // }
}