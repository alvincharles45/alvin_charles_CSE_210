using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
         Console.WriteLine("1. Start Breathing Activity");
         Console.WriteLine("2. Start Reflection Activity");
         Console.WriteLine("3. Start Listing Activity");
         Console.WriteLine("4. Start Gratitude Activity");
         Console.WriteLine("5. Quit");
         Console.Write("Choose an option (1-5): ");

            string? choice = Console.ReadLine();
            choice = choice ?? ""; 


            if (choice == "1")
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Run();
            }
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity();
                list.Run();
            }
            else if (choice == "4")
            {
                JournalActivity  journal = new JournalActivity();
                journal.Run();
            }

            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}