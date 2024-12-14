using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public string Weatherforecast
    {
        get {return _weatherForecast;}
        set{_weatherForecast = value;}
    }


    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {GetTitle()} on {GetDate()}";
    }
}