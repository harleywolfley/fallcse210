class BreathingActivity : BaseActivity
{
    public void RunActivity()
    {
        // call StartActivity()

        
        RunCountDownMessage("Get Ready", 5);
        DateTime endtime = DateTime.Now.AddSeconds(20); // delete later
        while (DateTime.Now < endtime)
        // while(! HasTimerExpired()) // Add later
        {
            RunCountDownMessage("Breathe in", 5);
            RunCountDownMessage("Breathe out", 5);
        }

        // call EndActivity()
    }
}