using System;
using System.ComponentModel;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public string Title
    {
        get {return _title;}
        set{_title = value;}
    }

    public string Description
    {
        get {return _description;}
        set{_description = value;}
    }

    public string Date
    {
        get {return _date;}
        set{_date = value;}
    }

    public string Time
    {
        get {return _time;}
        set{_time = value;}
    }

    public Address address
    {
        get {return _address;}
        set{_address = value;}
    }



    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {_title}\n Description: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public abstract string GetFullDetails();
    public abstract string GetShortDescription();

    protected string GetTitle() => _title;
    protected string GetDate() => _date;
}