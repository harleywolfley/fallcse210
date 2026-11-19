using System.Runtime.CompilerServices;

abstract class BaseGoal
{
    private string _name;
    private string _desc;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string desc, int points, bool complete, string goalType)
    {
        _name = name;
        _desc = desc;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {
        SetName();
        SetDesc();
        SetPoints();
        _complete = false;
        _goalType = goalType;
    }

    private void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    private void SetDesc()
    {
        Console.Write($"{_name} Goal Description: ");
        _desc = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.Write($"{_name} Goal Points: ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string GetConsoleString()
    {
        return $"[ ] {_name}: {_desc} - {_points}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public abstract int RecordEvent();
}
