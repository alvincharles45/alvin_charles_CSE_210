using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {

        List<string> prompts = new List<string> {"Who was the most interesting person I interacted with today?",
                                                "What was the best part of my day?",
                                                "How did I see the hand of the Lord in my life today?",
                                                "What was the strongest emotion I felt today?",
                                                "If I had one thing I could do over today, what would it be?"};
                

       string response=  "";
       Random promptrandom = new Random();
        int randomIndex = promptrandom.Next(prompts.Count);

        Journal journal = new Journal();

        while (response != "5")
        {
            Console.WriteLine("Please select an option (1-5): ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine( prompts[randomIndex]);
                string response1 = Console.ReadLine();
                Entry newEntry = new Entry(response1, DateTime.Now.ToString("MM/dd/yyyy"), prompts[randomIndex]);
                journal.AddJournal(newEntry);
                Console.WriteLine("Your entry has been added.");
            }
            else if (response == "2")
            {
                Console.WriteLine("Displaying all journal entries:");
                journal.Display();
            }
            else if (response == "3")
            {
                Console.WriteLine("Please enter the name of the file you want to load: ");
                string filename = Console.ReadLine();
                journal.RetrieveFromFile(filename);
            }
            else if (response == "4")
            {
                Console.WriteLine("Please enter the name of the file you want to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("File saved successfully.");
            }
            else if (response == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }

        
    }
}