class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string desc, int points, bool complete, string goalType)
    : base(name, desc, points, complete, goalType)
    {}

    public SimpleGoal() 
    : base("Simple Goal") 
    {}

    public override int RecordEvent()
    {
        if (IsComplete())
            return 0;
        return MarkComplete();
    }
}