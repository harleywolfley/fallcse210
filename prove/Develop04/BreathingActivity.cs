class BreathingActivity : BaseActivity
{
    // This class doesn't need anymore attributes or methods, but it does need to be finished linking together
    public BreathingActivity(): base()
    {
        // Only purpose is to initialize the base()
    }
    public void RunActivity()
    {
        // call StartActivity()

        
        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        // DateTime endtime = DateTime.Now.AddSeconds(20);
        // while (DateTime.Now < endtime)
        while(! HasTimerExpired())
        {
            RunCountDownMessage("Breathe in", 5);
            RunCountDownMessage("Breathe out", 5);
        }

        // call EndActivity()
    }
}