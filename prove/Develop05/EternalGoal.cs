using System.Threading.Tasks.Dataflow;

class EternalGoal : BaseGoal{
    private int _runningTotal;
    private int _targetCount;
    private int _bonusPoints;
    public EternalGoal(string name, string desc, int points, bool complete, string goalType)
    : base(name, desc, points, complete, goalType)
    {}

    public EternalGoal(string name, string desc, int points, bool complete, string goalType, int runningTotal, int targetCount, int bonusPoints)
    : base(name, desc, points, complete, goalType)
    {
        _runningTotal = runningTotal;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public EternalGoal() 
    : base("Eternal Goal")
    {
        Console.Write("How many times for a bonus? ");
        _targetCount = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _runningTotal++;
        int pointsEarned = GetPoints();

        if (_targetCount > 0 && _runningTotal % _targetCount == 0)
        {
            pointsEarned += _bonusPoints;
        }    

        return pointsEarned;
    }

    public override string GetConsoleString()
    {
        int progress = _targetCount > 0 ? _runningTotal % _targetCount : 0;
        return $"{base.GetConsoleString()}, Done: {_runningTotal} - {progress}/{_targetCount} (+{_bonusPoints})";
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{_runningTotal}|{_targetCount}|{_bonusPoints}";
    }
}