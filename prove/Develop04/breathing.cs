
using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") 
    { }

    public void Run()
    {
        StartMessage();
        int released = 0;
        while (released < _time)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();
            released += 4;

            if (released >= _time) break;

            Console.Write("Breathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
            released += 4;
        }
        EndMessage();
    }
}
