class BreathingActivity : BaseActivity
{
    // This class doesn't need anymore attributes or methods, but it does need to be finished linking together
    public BreathingActivity(): base()
    {/* Only purpose is to initialize the base()*/}
    public void RunActivity()
    {
        StartActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        while(! HasTimerExpired())
        {
            RunCountDownMessage("Breathe in", 5);
            RunCountDownMessage("Breathe out", 5);
        }

        EndActivity();
    }
}