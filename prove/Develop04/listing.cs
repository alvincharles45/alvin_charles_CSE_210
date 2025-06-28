
using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "List as many positive things in a category as you can.") 
    { }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($">>> {prompt} <<<");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndMessage();
    }
}
