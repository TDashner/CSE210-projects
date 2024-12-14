using System;

public class Reception : Event
{
    private string _emailRsvp;

    public string Emailrsvp
    {
        get {return _emailRsvp;}
        set{_emailRsvp = value;}
    }


    public Reception(string title, string description, string date, string time, Address address, string emailRsvp)
        : base(title, description, date, time, address)
    {
        _emailRsvp = emailRsvp;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_emailRsvp}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {GetTitle()} on {GetDate()}";
    }
}