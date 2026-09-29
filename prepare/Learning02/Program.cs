using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = "2019";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Food Service Worker";
        job2._company = "Frescos";
        job2._startYear = "2017";
        job2._endYear = "2019";

        Resume myResume = new Resume();
        myResume._name = "Harley Wolfley";
        myResume.allJobs.Add(job1);
        myResume.allJobs.Add(job2);

        myResume.DisplayAllItems();

    }
}