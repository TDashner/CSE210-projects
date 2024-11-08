using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Clear();
        int choice = -1;

        while (choice != 4)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice, please select a number between 1 and 4.");
            }

            switch (choice)
            {
                case 1:
                    var breathingActivity = new BreathingActivity();
                    await breathingActivity.StartAsync();  // Corrected
                    break;
                case 2:
                    var reflectionActivity = new ReflectionActivity();
                    await reflectionActivity.StartAsync();  // Corrected
                    break;
                case 3:
                    var listingActivity = new ListingActivity();
                    await listingActivity.StartAsync();  // Corrected
                    break;
                case 4:
                    Console.WriteLine("Thank you for participating in the activities!");  // Fixed missing semicolon
                    break;
            }
        }
    }
}
