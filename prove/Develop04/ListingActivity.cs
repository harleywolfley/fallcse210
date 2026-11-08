class ListingActivity : BaseActivity
{
    public ListingActivity(): base(){}

    List<string> prompts = new List<string>();
    private string _prompt;

    private void AddPrompts()
    {
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
    }

    private string DisplayPrompt()
    {
        Random myRandom = new Random();
        int index = myRandom.Next(prompts.Count);
        _prompt = prompts[index];
        Console.WriteLine(_prompt);
        return _prompt;
    }
    
    public void RunListActivity()
    {
        StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        RunCountDownMessage("Get Ready", 3);
        AddPrompts();
        Console.Clear();
        RunSpinnerMessage(DisplayPrompt(), 5);
        List<string> answers = new List<string>();
        StartTimer();
        while(! HasTimerExpired())
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            answers.Add(entry);
        }

        EndActivity();
    }
}