using System;

public class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "62701");
        Address address2 = new Address("456 Oak St", "Madison", "WI", "53703");
        Address address3 = new Address("789 Maple Ave", "Chicago", "IL", "60605");

        Event lecture = new Lecture("AI and the Future", "A lecture on artificial intelligence.", "2024-01-15", "10:00 AM", address1, "Dr. John Doe", 100);
        Event reception = new Reception("Spring Gala", "A networking reception for local professionals.", "2024-02-20", "6:00 PM", address2, "rsvp@springgala.com");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "An outdoor gathering to enjoy the summer weather.", "2024-07-04", "12:00 PM", address3, "Sunny, 75°F");

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
    
}