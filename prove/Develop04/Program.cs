using System;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("Which option would you like to choose?");
            var input = Console.ReadLine();

            if (input == "1")
                break;
            if (input == "2")
                break;
            if (input == "3")
                break;
            if (input == "4")
                break;



        }

    }

    // while (true)
    // {
    //     Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
    //     var input = Console.ReadLine();

    //     if (input?.ToLower() == "quit")
    //         break;

    //     if (!scripture.HideRandomWords(1))
    //         break;

    //     Console.Clear();
    //     Console.WriteLine($"{scripture.Reference}\n{scripture.GetDisplayText()}");
    // }
    
}




