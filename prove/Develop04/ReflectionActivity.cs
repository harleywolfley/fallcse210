class ReflectionActivity : BaseActivity
{
    public ReflectionActivity(): base()
    {/* Only purpose is to initialize the base()*/}

    List<string> prompts = new List<string>();
    List<string> moreprompts = new List<string>();
    private string _prompt;
    private string _anotherPrompt;
    private string _entry;

    private void AddPrompts()
    {
        prompts.Add("Think of a time when you stood up for someone else. ");
        prompts.Add("Think of a time when you did something really difficult. ");
        prompts.Add("Think of a time when you helped someone in need. ");
        prompts.Add("Think of a time when you did something truly selfless. ");
    }
    private void AddMorePrompts()
    {
        moreprompts.Add("Why was this experience meaningful to you?");
        moreprompts.Add("How did you get started?");
        moreprompts.Add("How did you feel when it was complete?");
        moreprompts.Add("What made this time different than other times when you were not as successful?");
        moreprompts.Add("What is your favorite thing about this experience?");
        moreprompts.Add("What could you learn from this experience that applies to other situations?");
        moreprompts.Add("How can you keep this experience in mind in the future?");
    }

    private string DisplayPrompt()
    {
        Random myRandom = new Random();
        int index = myRandom.Next(prompts.Count);
        _prompt = prompts[index];
        return _prompt;
    }

    private string DisplayAnotherPrompt()
    {
        Random myRandom = new Random();
        int index = myRandom.Next(moreprompts.Count);
        _anotherPrompt = moreprompts[index];
        return _anotherPrompt;
    }

    public void RunReflectActivity()
    {
        StartActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        RunCountDownMessage("Get Ready", 3);
        AddPrompts();
        AddMorePrompts();
        Console.Clear();
        Console.WriteLine(DisplayPrompt());
        RunSpinnerMessage("", 5);
        StartTimer();
        while(! HasTimerExpired())
        {
            Console.WriteLine(DisplayAnotherPrompt());
            Console.Write("> ");
            _entry = Console.ReadLine();
            RunSpinnerMessage("", 2);
        }

        EndActivity();
    }
}