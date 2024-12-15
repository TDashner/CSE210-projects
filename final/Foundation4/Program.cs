using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var _activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), 
            new Cycling(new DateTime(2022, 11, 4), 45, 12.0), 
            new Swimming(new DateTime(2022, 11, 5), 40, 40)   
        };

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
