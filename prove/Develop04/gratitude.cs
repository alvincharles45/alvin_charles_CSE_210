using System;
using System.Collections.Generic;

public class JournalActivity : MindfulnessActivity
{
    public JournalActivity() 
        : base("Journal Activity", "Reflect on your thoughts and feelings by writing them down.") 
    { }

    public void Run()
    {
        StartMessage();

        List<string> responses = new List<string>();
        Console.WriteLine("\nPlease take a moment to reflect on your day.");

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"  {i}. ");
          string? input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            responses.Add(input);
        }
else
{
    responses.Add("(empty)");
}

        }

        Console.WriteLine("\nThank you for reflecting!");
        Console.WriteLine("You entered:");
        foreach (var item in responses)
        {
            Console.WriteLine($"- {item}");
        }

        EndMessage();
    }
}