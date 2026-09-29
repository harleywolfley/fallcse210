using System.Runtime.CompilerServices;

public class Resume
{
    public string _name;
    public List<Job> allJobs = new List<Job>();

    public void DisplayAllItems()
    {
        Console.WriteLine(_name);

        foreach (Job job in allJobs)
        {
            job.DisplayJobs();
        }
    }
}