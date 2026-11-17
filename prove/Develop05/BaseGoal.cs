class BaseGoal
{
    private string _name;
    private string _desc;
    private int _points;

    public BaseGoal()
    {
        SetName();
        SetDesc();
        SetPoints();
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
}