
using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") 
    { }

    public void Run()
    {
        StartMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.Write("Breathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
            elapsed += 4;
        }
        EndMessage();
    }
}
