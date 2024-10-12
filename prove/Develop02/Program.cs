using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal!");  

        int input = 0;
        do
        {
            Console.WriteLine("Choose a number you would like to perform: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? "); 

            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            switch(input)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3: 
                    journal.Load();
                    break;
                case 4:
                    journal.Save();
                    break;
                case 5: 
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please select a number between 1 and 5.");
                    break;
            }

        }while (input !=5);
        



        // string choice = "";
        // make 5 into quit
        // while (input != 5)
        // {
        //     if (input == 1)
        //     {
        //         journal.AddEntry();
        //     }
        //     else if(input == 2)
        //     {
        //         journal.DisplayEntries();
        //     }
        //     else if(input == 3)
        //     {
        //         journal.Load();
        //     }
        //     else if(input == 4)
        //     {
        //         journal.Save();
        //     }
        //     else 
        //     {
        //         break;
        //     }

        //     Console.WriteLine("What would you like to do? ");
        //     input = Convert.ToInt16(Console.ReadLine());
        // }








       // Entry entry1 = new Entry("ASdf", 1, "fdas");

        

        //Console.WriteLine(entry1._date);
        //Console.WriteLine(entry1._note);
        //Console.WriteLine(entry1._prompt);




        


        
    }
}