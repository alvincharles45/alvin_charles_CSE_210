using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string GetSaveData();

    public override string ToString()
    {
        return $"{_name} ({_description})";
    }
}

// 🔥 StreakGoal (Stretch)
public class StreakGoal : Goal
{
    private int _streakCount;
    private DateTime _lastCompleted;

    public StreakGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _streakCount = 0;
        _lastCompleted = DateTime.MinValue;
    }

    public override void RecordEvent()
    {
        DateTime today = DateTime.Today;

        if (_lastCompleted == today)
        {
            Console.WriteLine("You've already completed this goal today!");
            return;
        }

        if (_lastCompleted == today.AddDays(-1))
        {
            _streakCount++;
        }
        else
        {
            _streakCount = 1;
        }

        _lastCompleted = today;
        Console.WriteLine($"Streak continued! You're on a {_streakCount}-day streak. You earned {_points} points!");
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[🔥 {_streakCount}-day streak]";

    public override string GetSaveData() =>
        $"Streak:{_name}|{_description}|{_points}|{_streakCount}|{_lastCompleted:yyyy-MM-dd}";
}
