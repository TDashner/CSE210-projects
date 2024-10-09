using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal!");        
        Console.WriteLine("Choose a number you would like to perform: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? "); 
        int input = Convert.ToInt16(Console.ReadLine());
        



        string choice = "";
        // make 5 into quit
        while (choice != "5")
        {
            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if(choice == "2")
            {
                journal.DisplayEntries();
            }
            else if(choice == "3")
            {
                journal.Load();
            }
            else if(choice == "4")
            {
                journal.Save();
            }
            else 
            {
                break;
            }

        }








       // Entry entry1 = new Entry("ASdf", 1, "fdas");

        

        //Console.WriteLine(entry1._date);
        //Console.WriteLine(entry1._note);
        //Console.WriteLine(entry1._prompt);




        


        
    }
}