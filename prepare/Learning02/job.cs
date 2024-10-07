using System;

public class Job
{
    public string _jobTitle;
    public string _comapny;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_comapny}) {_startYear}-{_endYear}");
    }
}
