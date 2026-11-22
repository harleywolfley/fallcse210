using System;

class Program
{
    static void Main(string[] args)
    {
        List<BaseGoal> myGoals = new List<BaseGoal>();
        int totalScore = 0;
        Console.Clear();
        Menu myMenu = new Menu();

        int _userInput = 0;
        while (_userInput < 6)
        {
            Console.Clear();
            Console.WriteLine($"Total Points: {totalScore}");
            _userInput = myMenu.RunMenu();
            switch (_userInput)
            {
                case 1:
                    Console.WriteLine("What type is your goal?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Goal Selection >  ");
                    int _goalTypeInput = int.Parse(Console.ReadLine());

                    switch (_goalTypeInput)
                    {
                        case 1:
                            myGoals.Add(new SimpleGoal());
                            break;
                        case 2:
                            myGoals.Add(new EternalGoal());
                            break;
                        case 3:
                            myGoals.Add(new CheckListGoal());
                            break;
                    }

                    break;

                case 2:
                    if (myGoals.Count == 0)
                    {
                        Console.WriteLine("No goals to display. Please load or create new goals.");
                    }
                    else
                    {
                        Console.WriteLine("Current Goals: ");
                        for (int i=0; i < myGoals.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {myGoals[i].GetConsoleString()}");
                        }
                    }

                    Console.WriteLine();
                    Console.Write("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Goals Filename: ");
                    string _saveFileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(_saveFileName))
                    {
                        foreach (BaseGoal goal in myGoals)
                        {
                            outputFile.WriteLine(goal.GetSaveString());
                        }
                    }
                    Console.WriteLine(Path.GetFullPath(_saveFileName));
                    Console.WriteLine("Saved.");
                    Console.Write("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Write("Goals Filename: ");
                    string _loadFileName = Console.ReadLine();

                    if (!File.Exists(_loadFileName))
                    {
                        Console.WriteLine("That file currently does not exist.");
                        break;
                    }

                    string[] lines = File.ReadAllLines(_loadFileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');

                        string goalType = parts[0];
                        string name = parts[1];
                        string desc = parts[2];
                        int points = int.Parse(parts[3]);
                        bool complete = bool.Parse(parts[4]);

                        switch (goalType)
                        {
                            case "Simple Goal":
                                myGoals.Add(new SimpleGoal(name, desc, points, complete, goalType));
                                break;
                            case "Eternal Goal":
                                int _runningTotal = int.Parse(parts[5]);
                                int _targetCount = int.Parse(parts[6]);
                                int _bonusPoints = int.Parse(parts[7]);
                                myGoals.Add(new EternalGoal(name, desc, points, complete, goalType, _runningTotal, _targetCount, _bonusPoints));
                                break;
                            case "Check List Goal":
                                int amountCompleted = int.Parse(parts[5]);
                                int target = int.Parse(parts[6]);
                                int bonusPoints = int.Parse(parts[7]);
                                myGoals.Add(new CheckListGoal(name, desc, points, complete, goalType, amountCompleted, target, bonusPoints));
                                break;
                        }
                    }

                    Console.WriteLine("Loaded.");
                    Console.Write("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case 5:
                    if (myGoals.Count == 0)
                    {
                        Console.WriteLine("You have no goals at this time.");
                    }
                    else
                    {
                        Console.WriteLine("What goal number did you accomplish?");
                        for (int i = 0; i < myGoals.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {myGoals[i].GetConsoleString()}");
                        }
                        Console.Write("Goal Selection > ");
                        int _goalIndex = int.Parse(Console.ReadLine()) - 1;

                        if (myGoals[_goalIndex].IsComplete())
                        {
                            Console.WriteLine("That goal is already complete!\nTotal Score: {totalScore}");
                        } 
                        else
                        {
                        int pointsEarned = myGoals[_goalIndex].RecordEvent();
                        totalScore += pointsEarned;

                        Console.WriteLine($"You earned {pointsEarned} points!\nTotal Score: {totalScore}");
                        }
                    }

                    Console.Write("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
