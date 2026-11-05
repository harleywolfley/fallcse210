class BaseActivity
{

    private int _duration;
    private DateTime _endTime;

    public BaseActivity () {
        _duration = 30; // Replace with call to ObtainDuration() --from user. this is hardcoded
    }

    public void StartActivity()
    {
        // COMPLETE
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