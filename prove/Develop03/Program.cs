using System;

namespace ScriptureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var reference = new ScriptureReference("John", 3, 16);
            var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            Console.Clear();
            Console.WriteLine($"{scripture.Reference}\n{scripture.GetDisplayText()}");

            while (true)
            {
                Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
                var input = Console.ReadLine();

                if (input?.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWords(1))
                    break;

                Console.Clear();
                Console.WriteLine($"{scripture.Reference}\n{scripture.GetDisplayText()}");
            }
        }
    }
}
