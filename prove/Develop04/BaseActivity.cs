using System.ComponentModel;

class BaseActivity
{
    private string _activityName;
    private string _description;
    private DateTime _endTime;
    private int _duration;

    public BaseActivity () {
        ObtainDuration();
    }

    public int ObtainDuration()
    {
        Console.WriteLine("How many seconds would you like this activity to last?\n");
        int _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public void StartActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        RunSpinnerMessage($"Welcome to the {_activityName} Activity.", 5);
        RunSpinnerMessage($"{_description}", 10);
        Console.Clear();
    }

    public void EndActivity()
    {
        RunSpinnerMessage("Well Done!", 5);
        RunCountDownMessage("Well Done!", 5);
        Console.Clear();
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        DateTime endtime = DateTime.Now.AddSeconds(seconds);
        // for(int i = 0; i < seconds; i++)
        while (DateTime.Now < endtime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
}