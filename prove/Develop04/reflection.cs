using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you get started?",
        "How did you feel afterwards?",
        "What is your favorite thing about this experience?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", "Reflect on times when you have shown strength and resilience.") 
    { }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt:\n>>> {prompt} <<<");
        ShowSpinner(5);

        DateTime closeTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < closeTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"\n> {question} ");
            ShowSpinner(5);
        }

        EndMessage();
    }
}