
using System;
using System.Threading;

public class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting: {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter duration in seconds: ");
       Console.Write("Enter duration in seconds: ");
       string? input = Console.ReadLine();
       if (int.TryParse(input, out int duration) && duration > 0)
       {
           _duration = duration;
       }
       else
      {
          Console.WriteLine("Invalid duration. Defaulting to 10 seconds.");
          _duration = 10;
     }

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGreat job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
