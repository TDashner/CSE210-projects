using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter = "";

        if (number >= 90)
        {   
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
            Console.WriteLine("You did not pass the class. Good luck next time!");
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)   
        {
            Console.WriteLine("Congradulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Good luck next time!");
        } 
    }
}