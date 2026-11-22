class CheckListGoal : BaseGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;
    public CheckListGoal(string name, string desc, int points, bool complete, string goalType)
    : base(name, desc, points, complete, goalType)
    {}

    public CheckListGoal(string name, string desc, int points, bool complete, string goalType, int amountCompleted, int target, int bonusPoints) 
    : base(name, desc, points, complete, goalType)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonusPoints = bonusPoints;
    }

    public CheckListGoal() 
    : base("Check List Goal")
    {
        Console.Write("How many times to complete? ");
        _target = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points for completion? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;   
        }

            _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            return MarkComplete() + _bonusPoints;
        }

        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} - {_amountCompleted}/{_target} (+{_bonusPoints})";
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{_amountCompleted}|{_target}|{_bonusPoints}";
    }
}