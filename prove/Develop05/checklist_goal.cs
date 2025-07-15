public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        int earned = _points;
        if (_completedCount == _targetCount)
        {
            earned += _bonus;
            Console.WriteLine("Bonus earned!");
        }
        Console.WriteLine($"You earned {earned} points!");
    }

    public override bool IsComplete() => _completedCount >= _targetCount;

    public override string GetStatus() => $"[{_completedCount}/{_targetCount}]";

    public override string GetSaveData() =>
        $"Checklist:{_name}|{_description}|{_points}|{_bonus}|{_completedCount}|{_targetCount}";
}
