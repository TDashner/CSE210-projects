using System;

class Program

{
    static void Main(string[] args)
    {
        List<int> numberList; // OR List<int> numberList = new(); 
        numberList = new(); // for both of these to be on the same line

        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter something: ");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            if (input != 0)
            {
                numberList.Add(input);
            }
        }

        foreach (int item in numberList)
        {
            Console.WriteLine(item);
        }

        //List<int> numberList;
        //These two are the same. You want the first one for a quicker way
        //numberList = new();
        //numberList = new List<int>();


    }
}